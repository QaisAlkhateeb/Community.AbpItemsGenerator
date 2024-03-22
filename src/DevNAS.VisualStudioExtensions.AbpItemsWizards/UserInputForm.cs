using System;
using System.Windows.Forms;

namespace DevNAS.VisualStudioExtensions.AbpItemsWizards
{
    public partial class UserInputForm : Form
    {
        private string _widgetName;
        private TextBox widgetNameTxt;
        private Panel panel1;
        private Label label1;
        private Button nextBtn;
        private bool _generateScriptBundle;
        private bool _generateStyleBundle;
        private string _refreshUrl;
        private string _viewPath;
        private CheckBox generateScriptBundleChk;
        private CheckBox generateStyleBundleChk;
        private TextBox refreshUrlTxt;
        private TextBox viewPathTxt;
        private Label generateScriptBundleLbl;
        private Label generateStyleBundleLbl;
        private Label refreshUrlLbl;
        private TextBox debugTxt;
        private Label viewPathLbl;



        public UserInputForm()
        {
            this.Size = new System.Drawing.Size(155, 265);

            InitializeComponent();
        }

        public string WidgetName
        {
            get
            {
                return _widgetName;
            }
            set
            {
                this.widgetNameTxt.Text = value;
                _widgetName = value;
            }
        }
        public bool GenerateScriptBundle
        {
            get { return _generateScriptBundle; }
            set
            {
                _generateScriptBundle = value;
                this.generateScriptBundleChk.Checked = value;
            }
        }

        public bool GenerateStyleBundle
        {
            get { return _generateStyleBundle; }
            set
            {
                _generateStyleBundle = value;
                this.generateStyleBundleChk.Checked = value;
            }
        }

        public string RefreshUrl
        {
            get { return _refreshUrl; }
            set
            {
                _refreshUrl = value;
                this.refreshUrlTxt.Text = value;
            }
        }

        public string ViewPath
        {
            get { return _viewPath; }
            set
            {
                _viewPath = value;
                this.viewPathTxt.Text = value;
            }
        }

        public string DebugTxt
        {
            get { return this.debugTxt.Text; }
            set
            {
                this.debugTxt.Text = value;
            }
        }


        private void InitializeComponent()
        {
            this.widgetNameTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nextBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.generateScriptBundleChk = new System.Windows.Forms.CheckBox();
            this.generateScriptBundleLbl = new System.Windows.Forms.Label();
            this.generateStyleBundleChk = new System.Windows.Forms.CheckBox();
            this.generateStyleBundleLbl = new System.Windows.Forms.Label();
            this.refreshUrlTxt = new System.Windows.Forms.TextBox();
            this.refreshUrlLbl = new System.Windows.Forms.Label();
            this.viewPathTxt = new System.Windows.Forms.TextBox();
            this.viewPathLbl = new System.Windows.Forms.Label();
            this.debugTxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // widgetNameTxt
            // 
            this.widgetNameTxt.Location = new System.Drawing.Point(18, 29);
            this.widgetNameTxt.Name = "widgetNameTxt";
            this.widgetNameTxt.Size = new System.Drawing.Size(362, 20);
            this.widgetNameTxt.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.debugTxt);
            this.panel1.Controls.Add(this.nextBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.widgetNameTxt);
            this.panel1.Controls.Add(this.generateScriptBundleChk);
            this.panel1.Controls.Add(this.generateScriptBundleLbl);
            this.panel1.Controls.Add(this.generateStyleBundleChk);
            this.panel1.Controls.Add(this.generateStyleBundleLbl);
            this.panel1.Controls.Add(this.refreshUrlTxt);
            this.panel1.Controls.Add(this.refreshUrlLbl);
            this.panel1.Controls.Add(this.viewPathTxt);
            this.panel1.Controls.Add(this.viewPathLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 253);
            this.panel1.TabIndex = 1;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(305, 221);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 2;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Widget Name";
            // 
            // generateScriptBundleChk
            // 
            this.generateScriptBundleChk.Location = new System.Drawing.Point(23, 145);
            this.generateScriptBundleChk.Name = "generateScriptBundleChk";
            this.generateScriptBundleChk.Size = new System.Drawing.Size(15, 14);
            this.generateScriptBundleChk.TabIndex = 3;
            // 
            // generateScriptBundleLbl
            // 
            this.generateScriptBundleLbl.Location = new System.Drawing.Point(44, 145);
            this.generateScriptBundleLbl.Name = "generateScriptBundleLbl";
            this.generateScriptBundleLbl.Size = new System.Drawing.Size(150, 13);
            this.generateScriptBundleLbl.TabIndex = 4;
            this.generateScriptBundleLbl.Text = "Generate Script Bundle";
            // 
            // generateStyleBundleChk
            // 
            this.generateStyleBundleChk.Location = new System.Drawing.Point(23, 165);
            this.generateStyleBundleChk.Name = "generateStyleBundleChk";
            this.generateStyleBundleChk.Size = new System.Drawing.Size(15, 14);
            this.generateStyleBundleChk.TabIndex = 4;
            // 
            // generateStyleBundleLbl
            // 
            this.generateStyleBundleLbl.Location = new System.Drawing.Point(44, 165);
            this.generateStyleBundleLbl.Name = "generateStyleBundleLbl";
            this.generateStyleBundleLbl.Size = new System.Drawing.Size(150, 13);
            this.generateStyleBundleLbl.TabIndex = 5;
            this.generateStyleBundleLbl.Text = "Generate Style Bundle";
            // 
            // refreshUrlTxt
            // 
            this.refreshUrlTxt.Location = new System.Drawing.Point(18, 72);
            this.refreshUrlTxt.Name = "refreshUrlTxt";
            this.refreshUrlTxt.Size = new System.Drawing.Size(362, 20);
            this.refreshUrlTxt.TabIndex = 5;
            // 
            // refreshUrlLbl
            // 
            this.refreshUrlLbl.Location = new System.Drawing.Point(18, 56);
            this.refreshUrlLbl.Name = "refreshUrlLbl";
            this.refreshUrlLbl.Size = new System.Drawing.Size(72, 13);
            this.refreshUrlLbl.TabIndex = 6;
            this.refreshUrlLbl.Text = "Refresh URL";
            // 
            // viewPathTxt
            // 
            this.viewPathTxt.Location = new System.Drawing.Point(18, 111);
            this.viewPathTxt.Name = "viewPathTxt";
            this.viewPathTxt.Size = new System.Drawing.Size(362, 20);
            this.viewPathTxt.TabIndex = 6;
            // 
            // viewPathLbl
            // 
            this.viewPathLbl.Location = new System.Drawing.Point(18, 95);
            this.viewPathLbl.Name = "viewPathLbl";
            this.viewPathLbl.Size = new System.Drawing.Size(72, 13);
            this.viewPathLbl.TabIndex = 7;
            this.viewPathLbl.Text = "View Path";
            // 
            // debugTxt
            // 
            this.debugTxt.Location = new System.Drawing.Point(18, 223);
            this.debugTxt.Name = "debugTxt";
            this.debugTxt.ReadOnly = true;
            this.debugTxt.Size = new System.Drawing.Size(167, 20);
            this.debugTxt.TabIndex = 8;
            // 
            // UserInputForm
            // 
            this.ClientSize = new System.Drawing.Size(389, 253);
            this.Controls.Add(this.panel1);
            this.Name = "UserInputForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            _widgetName = widgetNameTxt.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
