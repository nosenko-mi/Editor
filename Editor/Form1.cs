using Editor.Factory;
using Editor.utils;
using Editor.utils.eventtypes;
using Editor.utils.logger;
using Editor.utils.multiton;
using Editor.utils.singleton;
using System.Diagnostics;
using System.Windows.Forms;

namespace Editor
{
    public partial class MainForm : Form
    {
        private string filePath;
        private bool textChanged;
        private Logger logger = Singleton<Logger>.Instance;
        private string _previousText = string.Empty;
        private static readonly FileFactory _defaultFactory = new TextFileFactory();
        private FileFactory _factory = _defaultFactory;

        public MainForm()
        {
            InitializeComponent();

            this.filePath = "";
            this.textChanged = false;
        }

        internal TextStatisticsProvider TextStatisticsProvider
        {
            get => default;
            set
            {
            }
        }

        internal ZnuNewsProvider ZnuNewsProvider
        {
            get => default;
            set
            {
            }
        }

        private void WriteText(string filePath)
        {
            this.filePath = filePath;
            // get content
            string content = textEditor.Text;
            // Get file from factory : content
            // Save file : path
            _factory.SaveFile(filePath, content);

            //System.IO.File.WriteAllText(this.filePath, this.textEditor.Text);
            this.textChanged = false;
        }

        private void SaveAs()
        {
            saveFileDialog.Filter = SaveFilters.All();
            if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // get new filter
                string[] split = saveFileDialog.Filter.Split('|');
                int index = saveFileDialog.FilterIndex;
                string currentFilter = split[(index - 1) * 2] + "|" + split[(index - 1) * 2 + 1];
                Debugger.Log(1, "main", currentFilter);

                // get factory for given filter
                _factory = SaveFilters.GetFactory(currentFilter);
                // write file
                this.WriteText(this.saveFileDialog.FileName);
            }
        }

        private void Save()
        {
            if (this.filePath == null || this.filePath == "")
            {
                this.SaveAs();
            }
            else
            {
                this.WriteText(this.filePath);
            }
        }

        private void SaveChanges()
        {
            if (this.textChanged)
            {
                if (MessageBox.Show("Save changes?", "Text is changed", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Save();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveChanges();
            this.textEditor.Clear();
            this.textChanged = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.SaveChanges();
                this.filePath = this.openFileDialog.FileName;
                string text = System.IO.File.ReadAllText(this.filePath);
                this.textEditor.Text = text;
                this.textChanged = false;
                _previousText = text;
                _factory = _defaultFactory;
            }
        }

        private void textEditor_TextChanged(object sender, EventArgs e)
        {
            this.textChanged = true;
            this.ShowStatistics();

            int lineIndex = textEditor.GetLineFromCharIndex(textEditor.SelectionStart);
            int columnIndex = textEditor.SelectionStart - textEditor.GetFirstCharIndexOfCurrentLine();

            try
            {
                if (_previousText.Length < textEditor.Text.Length)
                {
                    logger.Log(EventType.ADD, lineIndex, columnIndex);
                }
                else if (_previousText.Length > textEditor.Text.Length)
                {
                    logger.Log(EventType.DELETE, lineIndex, columnIndex);
                }
                else
                {
                    logger.Log(EventType.ADD, lineIndex, columnIndex);
                }
            }
            catch (Exception ex) { Debugger.Log(1, "main", ex.Message); }

            _previousText = textEditor.Text;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.SaveChanges();
            Logger.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveAs();
        }

        private void ShowStatistics()
        {
            TextStatisticsProvider provider = new TextStatisticsProvider(this.textEditor.Text);
            var stats = provider.Calc();
            this.mainStatusBar.Items.Clear();
            foreach (var pair in stats)
            {
                this.mainStatusBar.Items.Add(pair.Value);
            }
        }

        private void loadZNUNewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZnuNewsProvider provider = new ZnuNewsProvider();
            textEditor.Text += provider.Load();
        }
    }
}