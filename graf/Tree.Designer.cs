namespace graf
{
    partial class treeForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.view = new System.Windows.Forms.Button();
            this.addVertex = new System.Windows.Forms.Button();
            this.deleteVertex = new System.Windows.Forms.Button();
            this.deleteTree = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменадействияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменадействияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.деревоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aProgrammToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputNodeBox = new System.Windows.Forms.TextBox();
            this.inputNodeTxt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listVertex = new System.Windows.Forms.ComboBox();
            this.viewList = new System.Windows.Forms.ComboBox();
            this.propertiesBox = new System.Windows.Forms.TextBox();
            this.propertiesLabel = new System.Windows.Forms.Label();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2556, 826);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(9, 32);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(94, 42);
            this.view.TabIndex = 1;
            this.view.Text = "обзор";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // addVertex
            // 
            this.addVertex.Location = new System.Drawing.Point(9, 80);
            this.addVertex.Name = "addVertex";
            this.addVertex.Size = new System.Drawing.Size(94, 42);
            this.addVertex.TabIndex = 2;
            this.addVertex.Text = "добавить\r\nузел";
            this.addVertex.UseVisualStyleBackColor = true;
            this.addVertex.Click += new System.EventHandler(this.addVertex_Click);
            // 
            // deleteVertex
            // 
            this.deleteVertex.Location = new System.Drawing.Point(9, 128);
            this.deleteVertex.Name = "deleteVertex";
            this.deleteVertex.Size = new System.Drawing.Size(94, 42);
            this.deleteVertex.TabIndex = 3;
            this.deleteVertex.Text = "удалить\r\nузел";
            this.deleteVertex.UseVisualStyleBackColor = true;
            this.deleteVertex.Click += new System.EventHandler(this.deleteVertex_Click);
            // 
            // deleteTree
            // 
            this.deleteTree.Location = new System.Drawing.Point(9, 176);
            this.deleteTree.Name = "deleteTree";
            this.deleteTree.Size = new System.Drawing.Size(94, 42);
            this.deleteTree.TabIndex = 4;
            this.deleteTree.Text = "удалить\r\nдерево";
            this.deleteTree.UseVisualStyleBackColor = true;
            this.deleteTree.Click += new System.EventHandler(this.deleteTree_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.changeToolStripMenuItem,
            this.видToolStripMenuItem,
            this.serviceToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1236, 24);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "&Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Вы&ход";
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменадействияToolStripMenuItem,
            this.отменадействияToolStripMenuItem1});
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.changeToolStripMenuItem.Text = "&Правка";
            // 
            // отменадействияToolStripMenuItem
            // 
            this.отменадействияToolStripMenuItem.Name = "отменадействияToolStripMenuItem";
            this.отменадействияToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.отменадействияToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.отменадействияToolStripMenuItem.Text = "&Отмена действия";
            // 
            // отменадействияToolStripMenuItem1
            // 
            this.отменадействияToolStripMenuItem1.Name = "отменадействияToolStripMenuItem1";
            this.отменадействияToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.отменадействияToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.отменадействияToolStripMenuItem1.Text = "&Отмена действия";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.графToolStripMenuItem,
            this.деревоToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // графToolStripMenuItem
            // 
            this.графToolStripMenuItem.Name = "графToolStripMenuItem";
            this.графToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.графToolStripMenuItem.Text = "Граф";
            this.графToolStripMenuItem.Click += new System.EventHandler(this.графToolStripMenuItem_Click);
            // 
            // деревоToolStripMenuItem
            // 
            this.деревоToolStripMenuItem.Name = "деревоToolStripMenuItem";
            this.деревоToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.деревоToolStripMenuItem.Text = "Дерево";
            this.деревоToolStripMenuItem.Click += new System.EventHandler(this.деревоToolStripMenuItem_Click);
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.параметрыToolStripMenuItem});
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.serviceToolStripMenuItem.Text = "&Сервис";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.настройкиToolStripMenuItem.Text = "&Настройки";
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.параметрыToolStripMenuItem.Text = "&Параметры";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.aProgrammToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.aboutToolStripMenuItem.Text = "Спра&вка";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(155, 6);
            // 
            // aProgrammToolStripMenuItem
            // 
            this.aProgrammToolStripMenuItem.Name = "aProgrammToolStripMenuItem";
            this.aProgrammToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.aProgrammToolStripMenuItem.Text = "&О программе...";
            this.aProgrammToolStripMenuItem.Click += new System.EventHandler(this.aProgrammToolStripMenuItem_Click);
            // 
            // inputNodeBox
            // 
            this.inputNodeBox.Location = new System.Drawing.Point(109, 102);
            this.inputNodeBox.Name = "inputNodeBox";
            this.inputNodeBox.Size = new System.Drawing.Size(77, 20);
            this.inputNodeBox.TabIndex = 12;
            // 
            // inputNodeTxt
            // 
            this.inputNodeTxt.AutoSize = true;
            this.inputNodeTxt.Location = new System.Drawing.Point(109, 86);
            this.inputNodeTxt.Name = "inputNodeTxt";
            this.inputNodeTxt.Size = new System.Drawing.Size(74, 13);
            this.inputNodeTxt.TabIndex = 13;
            this.inputNodeTxt.Text = "введите узел\r\n";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(219, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 484);
            this.panel1.TabIndex = 14;
            // 
            // listVertex
            // 
            this.listVertex.FormattingEnabled = true;
            this.listVertex.Location = new System.Drawing.Point(109, 149);
            this.listVertex.Name = "listVertex";
            this.listVertex.Size = new System.Drawing.Size(76, 21);
            this.listVertex.Sorted = true;
            this.listVertex.TabIndex = 16;
            // 
            // viewList
            // 
            this.viewList.BackColor = System.Drawing.SystemColors.Control;
            this.viewList.FormattingEnabled = true;
            this.viewList.Location = new System.Drawing.Point(92, 365);
            this.viewList.Name = "viewList";
            this.viewList.Size = new System.Drawing.Size(91, 21);
            this.viewList.Sorted = true;
            this.viewList.TabIndex = 17;
            // 
            // propertiesBox
            // 
            this.propertiesBox.BackColor = System.Drawing.SystemColors.Control;
            this.propertiesBox.Location = new System.Drawing.Point(9, 395);
            this.propertiesBox.Multiline = true;
            this.propertiesBox.Name = "propertiesBox";
            this.propertiesBox.ReadOnly = true;
            this.propertiesBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.propertiesBox.Size = new System.Drawing.Size(201, 148);
            this.propertiesBox.TabIndex = 18;
            // 
            // propertiesLabel
            // 
            this.propertiesLabel.AutoSize = true;
            this.propertiesLabel.Location = new System.Drawing.Point(12, 373);
            this.propertiesLabel.Name = "propertiesLabel";
            this.propertiesLabel.Size = new System.Drawing.Size(55, 13);
            this.propertiesLabel.TabIndex = 19;
            this.propertiesLabel.Text = "Свойства";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить ";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // treeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 558);
            this.Controls.Add(this.propertiesLabel);
            this.Controls.Add(this.propertiesBox);
            this.Controls.Add(this.viewList);
            this.Controls.Add(this.listVertex);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.inputNodeTxt);
            this.Controls.Add(this.inputNodeBox);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.deleteTree);
            this.Controls.Add(this.deleteVertex);
            this.Controls.Add(this.addVertex);
            this.Controls.Add(this.view);
            this.Name = "treeForm";
            this.Text = "Tree";
            this.Load += new System.EventHandler(this.treeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button addVertex;
        private System.Windows.Forms.Button deleteVertex;
        private System.Windows.Forms.Button deleteTree;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменадействияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменадействияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem деревоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aProgrammToolStripMenuItem;
        private System.Windows.Forms.TextBox inputNodeBox;
        private System.Windows.Forms.Label inputNodeTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox listVertex;
        private System.Windows.Forms.ComboBox viewList;
        private System.Windows.Forms.TextBox propertiesBox;
        private System.Windows.Forms.Label propertiesLabel;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
    }
}