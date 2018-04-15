namespace WinFormslab2
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
            this.mainWind = new System.Windows.Forms.PictureBox();
            this.menuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.editBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.deleteVertexButton = new System.Windows.Forms.Button();
            this.deleteGraphButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.colorShower = new System.Windows.Forms.Panel();
            this.colorButton = new System.Windows.Forms.Button();
            this.langBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.plLangButton = new System.Windows.Forms.Button();
            this.engLangButton = new System.Windows.Forms.Button();
            this.saveBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.importButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.mainWind)).BeginInit();
            this.menuPanel.SuspendLayout();
            this.editBox.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.langBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.saveBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainWind
            // 
            resources.ApplyResources(this.mainWind, "mainWind");
            this.mainWind.BackColor = System.Drawing.Color.White;
            this.mainWind.Name = "mainWind";
            this.mainWind.TabStop = false;
            this.mainWind.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainWind_MouseDown);
            this.mainWind.MouseEnter += new System.EventHandler(this.mainWind_MouseEnter);
            this.mainWind.MouseLeave += new System.EventHandler(this.mainWind_MouseLeave);
            this.mainWind.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainWind_MouseMove);
            this.mainWind.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainWind_MouseUp);
            // 
            // menuPanel
            // 
            resources.ApplyResources(this.menuPanel, "menuPanel");
            this.menuPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuPanel.Controls.Add(this.editBox, 0, 0);
            this.menuPanel.Controls.Add(this.langBox, 0, 1);
            this.menuPanel.Controls.Add(this.saveBox, 0, 2);
            this.menuPanel.Name = "menuPanel";
            // 
            // editBox
            // 
            resources.ApplyResources(this.editBox, "editBox");
            this.editBox.Controls.Add(this.tableLayoutPanel4);
            this.editBox.Controls.Add(this.tableLayoutPanel1);
            this.editBox.Name = "editBox";
            this.editBox.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.deleteVertexButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.deleteGraphButton, 0, 1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // deleteVertexButton
            // 
            resources.ApplyResources(this.deleteVertexButton, "deleteVertexButton");
            this.deleteVertexButton.Name = "deleteVertexButton";
            this.deleteVertexButton.UseVisualStyleBackColor = true;
            this.deleteVertexButton.Click += new System.EventHandler(this.deleteVertexButton_Click);
            // 
            // deleteGraphButton
            // 
            resources.ApplyResources(this.deleteGraphButton, "deleteGraphButton");
            this.deleteGraphButton.Name = "deleteGraphButton";
            this.deleteGraphButton.UseVisualStyleBackColor = true;
            this.deleteGraphButton.Click += new System.EventHandler(this.deleteGraphButton_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.colorShower, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.colorButton, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // colorShower
            // 
            resources.ApplyResources(this.colorShower, "colorShower");
            this.colorShower.Name = "colorShower";
            // 
            // colorButton
            // 
            resources.ApplyResources(this.colorButton, "colorButton");
            this.colorButton.Name = "colorButton";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // langBox
            // 
            resources.ApplyResources(this.langBox, "langBox");
            this.langBox.Controls.Add(this.tableLayoutPanel2);
            this.langBox.Name = "langBox";
            this.langBox.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.plLangButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.engLangButton, 0, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // plLangButton
            // 
            resources.ApplyResources(this.plLangButton, "plLangButton");
            this.plLangButton.Name = "plLangButton";
            this.plLangButton.UseVisualStyleBackColor = true;
            this.plLangButton.Click += new System.EventHandler(this.plLangButton_Click);
            // 
            // engLangButton
            // 
            resources.ApplyResources(this.engLangButton, "engLangButton");
            this.engLangButton.Name = "engLangButton";
            this.engLangButton.UseVisualStyleBackColor = true;
            this.engLangButton.Click += new System.EventHandler(this.engLangButton_Click);
            // 
            // saveBox
            // 
            resources.ApplyResources(this.saveBox, "saveBox");
            this.saveBox.Controls.Add(this.tableLayoutPanel3);
            this.saveBox.Name = "saveBox";
            this.saveBox.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.importButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.saveButton, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // importButton
            // 
            resources.ApplyResources(this.importButton, "importButton");
            this.importButton.Name = "importButton";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // pictureContainer
            // 
            resources.ApplyResources(this.pictureContainer, "pictureContainer");
            this.pictureContainer.Name = "pictureContainer";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.mainWind);
            this.panel1.Name = "panel1";
            // 
            // saveFileDialog
            // 
            resources.ApplyResources(this.saveFileDialog, "saveFileDialog");
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "SavedGraph";
            resources.ApplyResources(this.openFileDialog, "openFileDialog");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureContainer);
            this.Controls.Add(this.menuPanel);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.mainWind)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.editBox.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.langBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.saveBox.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox mainWind;
        private System.Windows.Forms.TableLayoutPanel menuPanel;
        private System.Windows.Forms.GroupBox editBox;
        private System.Windows.Forms.GroupBox langBox;
        private System.Windows.Forms.GroupBox saveBox;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button engLangButton;
        private System.Windows.Forms.Button plLangButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel colorShower;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel pictureContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button deleteVertexButton;
        private System.Windows.Forms.Button deleteGraphButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

