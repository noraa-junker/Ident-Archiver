using System.Text.RegularExpressions;

namespace Ident_Archiver
{
    public partial class EditEntryForm : Form
    {
        private readonly string _entriesPath;
        private readonly string _mediaPath;
        private string? _selectedEntryFilePath;
        private string? _selectedMediaFilePath;

        private const string MarkdownTemplate =
            """
            ---
            layout: entry
            title: {0}
            organization: {1}
            usagedate: {2}
            language: {3}
            fulltitle: {4}
            watermark: {5}
            ---
            """;

        private const string MarkdownTemplateWithSource =
            """
            ---
            layout: entry
            title: {0}
            organization: {1}
            usagedate: {2}
            language: {3}
            fulltitle: {4}
            watermark: {5}
            sourceurl: {6}
            source: {7}
            ---
            """;

        private static readonly Regex FrontMatterRegex = new(@"^---\s*\r?\n(?<content>[\s\S]*?)\r?\n---\s*$", RegexOptions.Compiled);

        public EditEntryForm()
        {
            InitializeComponent();

            _entriesPath = Path.Combine(Properties.Settings.Default.repolocation, "_entries");
            _mediaPath = Path.Combine(Properties.Settings.Default.repolocation, "media");

            LoadEntries();
        }

        private void LoadEntries()
        {
            EntryComboBox.Items.Clear();

            if (!Directory.Exists(_entriesPath))
            {
                return;
            }

            foreach (string filePath in Directory.GetFiles(_entriesPath, "*.md").OrderBy(Path.GetFileName))
            {
                EntryComboBox.Items.Add(Path.GetFileNameWithoutExtension(filePath));
            }
        }

        private static Dictionary<string, string> ParseFrontMatter(string markdown)
        {
            Match match = FrontMatterRegex.Match(markdown);
            if (!match.Success)
            {
                return [];
            }

            Dictionary<string, string> fields = new(StringComparer.OrdinalIgnoreCase);
            string content = match.Groups["content"].Value;
            using StringReader reader = new(content);
            while (reader.ReadLine() is { } line)
            {
                int separatorIndex = line.IndexOf(':');
                if (separatorIndex <= 0)
                {
                    continue;
                }

                string key = line[..separatorIndex].Trim();
                string value = line[(separatorIndex + 1)..].Trim();
                fields[key] = value;
            }

            return fields;
        }

        private void EntryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedName = EntryComboBox.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(selectedName))
            {
                return;
            }

            string markdownPath = Path.Combine(_entriesPath, selectedName + ".md");
            if (!File.Exists(markdownPath))
            {
                MessageBox.Show("Selected entry was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _selectedEntryFilePath = markdownPath;

            string markdown = File.ReadAllText(markdownPath);
            Dictionary<string, string> fields = ParseFrontMatter(markdown);

            ShortNameTextBox.Text = fields.TryGetValue("title", out string? title) ? title : "";
            OrganizationTextBox.Text = fields.TryGetValue("organization", out string? organization) ? organization : "";
            DateTextBox.Text = fields.TryGetValue("usagedate", out string? usageDate) ? usageDate : "";
            LangTextBox.Text = fields.TryGetValue("language", out string? language) ? language : "";
            LongNameTextBox.Text = fields.TryGetValue("fulltitle", out string? fullTitle) ? fullTitle : "";
            WatermarkTextBox.Text = fields.TryGetValue("watermark", out string? watermark) ? watermark : "";
            STextBox.Text = fields.TryGetValue("sourceurl", out string? sourceUrl) ? sourceUrl : "";
            STTextBox.Text = fields.TryGetValue("source", out string? source) ? source : "";

            string entryBaseName = Path.GetFileNameWithoutExtension(markdownPath);
            _selectedMediaFilePath = Directory.Exists(_mediaPath)
                ? Directory.GetFiles(_mediaPath, entryBaseName + ".*").FirstOrDefault()
                : null;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!CheckRequiredFields())
            {
                MessageBox.Show("Please fill out all required metadata fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(_selectedEntryFilePath) || !File.Exists(_selectedEntryFilePath))
            {
                MessageBox.Show("Please select an entry first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string oldBaseName = Path.GetFileNameWithoutExtension(_selectedEntryFilePath);
            string newBaseName = $"{OrganizationTextBox.Text}-{ShortNameTextBox.Text}-{WatermarkTextBox.Text}-{LangTextBox.Text}-{DateTextBox.Text}";
            string newEntryPath = Path.Combine(_entriesPath, newBaseName + ".md");

            if (!oldBaseName.Equals(newBaseName, StringComparison.OrdinalIgnoreCase) && File.Exists(newEntryPath))
            {
                MessageBox.Show("An entry with the new filename already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string markdown = string.IsNullOrWhiteSpace(STextBox.Text)
                ? string.Format(MarkdownTemplate, ShortNameTextBox.Text, OrganizationTextBox.Text, DateTextBox.Text, LangTextBox.Text, LongNameTextBox.Text, WatermarkTextBox.Text)
                : string.Format(MarkdownTemplateWithSource, ShortNameTextBox.Text, OrganizationTextBox.Text, DateTextBox.Text, LangTextBox.Text, LongNameTextBox.Text, WatermarkTextBox.Text, STextBox.Text, STTextBox.Text);

            if (!oldBaseName.Equals(newBaseName, StringComparison.OrdinalIgnoreCase))
            {
                File.Move(_selectedEntryFilePath, newEntryPath);
                _selectedEntryFilePath = newEntryPath;

                if (!string.IsNullOrWhiteSpace(_selectedMediaFilePath) && File.Exists(_selectedMediaFilePath))
                {
                    string extension = Path.GetExtension(_selectedMediaFilePath);
                    string newMediaPath = Path.Combine(_mediaPath, newBaseName + extension);
                    if (File.Exists(newMediaPath))
                    {
                        MessageBox.Show("A media file with the new filename already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    File.Move(_selectedMediaFilePath, newMediaPath);
                    _selectedMediaFilePath = newMediaPath;
                }
            }

            File.WriteAllText(_selectedEntryFilePath, markdown);

            LoadEntries();
            EntryComboBox.SelectedItem = newBaseName;
            MessageBox.Show("Entry metadata updated.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool CheckRequiredFields()
        {
            return OrganizationTextBox.Text != "" &&
                   ShortNameTextBox.Text != "" &&
                   LangTextBox.Text != "" &&
                   DateTextBox.Text != "" &&
                   LongNameTextBox.Text != "" &&
                   WatermarkTextBox.Text != "";
        }
    }
}
