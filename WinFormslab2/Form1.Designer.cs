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
            this.mainWind = new System.Windows.Forms.PictureBox();
            this.menuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.editBox = new System.Windows.Forms.GroupBox();
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.deleteVertexButton = new System.Windows.Forms.Button();
            this.deleteGraphButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainWind)).BeginInit();
            this.menuPanel.SuspendLayout();
            this.editBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.langBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.saveBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainWind
            // 
            this.mainWind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainWind.BackColor = System.Drawing.Color.White;
            this.mainWind.Location = new System.Drawing.Point(0, 0);
            this.mainWind.Name = "mainWind";
            this.mainWind.Size = new System.Drawing.Size(584, 562);
            this.mainWind.TabIndex = 1;
            this.mainWind.TabStop = false;
            this.mainWind.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainWind_MouseDown);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuPanel.ColumnCount = 1;
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuPanel.Controls.Add(this.editBox, 0, 0);
            this.menuPanel.Controls.Add(this.langBox, 0, 1);
            this.menuPanel.Controls.Add(this.saveBox, 0, 2);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuPanel.Location = new System.Drawing.Point(584, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.RowCount = 3;
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.menuPanel.Size = new System.Drawing.Size(200, 562);
            this.menuPanel.TabIndex = 2;
            // 
            // editBox
            // 
            this.editBox.Controls.Add(this.tableLayoutPanel4);
            this.editBox.Controls.Add(this.tableLayoutPanel1);
            this.editBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editBox.Location = new System.Drawing.Point(3, 3);
            this.editBox.Name = "editBox";
            this.editBox.Size = new System.Drawing.Size(194, 316);
            this.editBox.TabIndex = 0;
            this.editBox.TabStop = false;
            this.editBox.Text = "Edycja";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.Controls.Add(this.colorShower, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.colorButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(188, 32);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // colorShower
            // 
            this.colorShower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorShower.Location = new System.Drawing.Point(124, 3);
            this.colorShower.Name = "colorShower";
            this.colorShower.Size = new System.Drawing.Size(61, 24);
            this.colorShower.TabIndex = 3;
            // 
            // colorButton
            // 
            this.colorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorButton.Location = new System.Drawing.Point(3, 3);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(115, 24);
            this.colorButton.TabIndex = 0;
            this.colorButton.Text = "Kolor";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // langBox
            // 
            this.langBox.Controls.Add(this.tableLayoutPanel2);
            this.langBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.langBox.Location = new System.Drawing.Point(3, 325);
            this.langBox.Name = "langBox";
            this.langBox.Size = new System.Drawing.Size(194, 114);
            this.langBox.TabIndex = 1;
            this.langBox.TabStop = false;
            this.langBox.Text = "Język";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.plLangButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.engLangButton, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(188, 95);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // plLangButton
            // 
            this.plLangButton.AutoSize = true;
            this.plLangButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plLangButton.Location = new System.Drawing.Point(3, 3);
            this.plLangButton.Name = "plLangButton";
            this.plLangButton.Size = new System.Drawing.Size(182, 41);
            this.plLangButton.TabIndex = 0;
            this.plLangButton.Text = "Polski";
            this.plLangButton.UseVisualStyleBackColor = true;
            // 
            // engLangButton
            // 
            this.engLangButton.AutoSize = true;
            this.engLangButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.engLangButton.Location = new System.Drawing.Point(3, 50);
            this.engLangButton.Name = "engLangButton";
            this.engLangButton.Size = new System.Drawing.Size(182, 42);
            this.engLangButton.TabIndex = 1;
            this.engLangButton.Text = "Angielski";
            this.engLangButton.UseVisualStyleBackColor = true;
            // 
            // saveBox
            // 
            this.saveBox.Controls.Add(this.tableLayoutPanel3);
            this.saveBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveBox.Location = new System.Drawing.Point(3, 445);
            this.saveBox.Name = "saveBox";
            this.saveBox.Size = new System.Drawing.Size(194, 114);
            this.saveBox.TabIndex = 2;
            this.saveBox.TabStop = false;
            this.saveBox.Text = "Import/Eksport";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.importButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.saveButton, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(188, 95);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // importButton
            // 
            this.importButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importButton.Location = new System.Drawing.Point(3, 50);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(182, 42);
            this.importButton.TabIndex = 2;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton.Location = new System.Drawing.Point(3, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(182, 41);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // pictureContainer
            // 
            this.pictureContainer.AutoSize = true;
            this.pictureContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pictureContainer.Location = new System.Drawing.Point(3, 3);
            this.pictureContainer.Name = "pictureContainer";
            this.pictureContainer.Size = new System.Drawing.Size(0, 0);
            this.pictureContainer.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.mainWind);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 562);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.deleteVertexButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.deleteGraphButton, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 48);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(188, 265);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // deleteVertexButton
            // 
            this.deleteVertexButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteVertexButton.Location = new System.Drawing.Point(3, 3);
            this.deleteVertexButton.Name = "deleteVertexButton";
            this.deleteVertexButton.Size = new System.Drawing.Size(182, 24);
            this.deleteVertexButton.TabIndex = 0;
            this.deleteVertexButton.Text = "Usun Wierzchołek";
            this.deleteVertexButton.UseVisualStyleBackColor = true;
            // 
            // deleteGraphButton
            // 
            this.deleteGraphButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteGraphButton.Location = new System.Drawing.Point(3, 33);
            this.deleteGraphButton.Name = "deleteGraphButton";
            this.deleteGraphButton.Size = new System.Drawing.Size(182, 24);
            this.deleteGraphButton.TabIndex = 1;
            this.deleteGraphButton.Text = "Usun Graf";
            this.deleteGraphButton.UseVisualStyleBackColor = true;
            this.deleteGraphButton.Click += new System.EventHandler(this.deleteGraphButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureContainer);
            this.Controls.Add(this.menuPanel);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edytor Grafów";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.mainWind)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.editBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.langBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.saveBox.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
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
    }
}

