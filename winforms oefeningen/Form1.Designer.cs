namespace winforms_oefeningen
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelectie = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbContent = new System.Windows.Forms.ListBox();
            this.btnBewaren = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cbSelectie
            // 
            this.cbSelectie.FormattingEnabled = true;
            resources.ApplyResources(this.cbSelectie, "cbSelectie");
            this.cbSelectie.Name = "cbSelectie";
            this.cbSelectie.SelectedIndexChanged += new System.EventHandler(this.cbSelectie_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbContent
            // 
            this.lbContent.FormattingEnabled = true;
            resources.ApplyResources(this.lbContent, "lbContent");
            this.lbContent.Name = "lbContent";
            this.lbContent.SelectedIndexChanged += new System.EventHandler(this.lbContent_SelectedIndexChanged);
            // 
            // btnBewaren
            // 
            resources.ApplyResources(this.btnBewaren, "btnBewaren");
            this.btnBewaren.Name = "btnBewaren";
            this.btnBewaren.UseVisualStyleBackColor = true;
            this.btnBewaren.Click += new System.EventHandler(this.btnBewaren_Click);
            // 
            // btnVerwijderen
            // 
            resources.ApplyResources(this.btnVerwijderen, "btnVerwijderen");
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnBewaren);
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbSelectie);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSelectie;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbContent;
        private System.Windows.Forms.Button btnBewaren;
        private System.Windows.Forms.Button btnVerwijderen;
    }
}

