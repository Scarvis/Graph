namespace graf
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vertex = new System.Windows.Forms.Button();
            this.edge = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.dfs = new System.Windows.Forms.Button();
            this.delVertex = new System.Windows.Forms.Button();
            this.delEdge = new System.Windows.Forms.Button();
            this.delGraph = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменадействияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменадействияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aProgrammToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.forward = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(665, 395);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(24, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(807, 307);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // vertex
            // 
            this.vertex.Location = new System.Drawing.Point(114, 369);
            this.vertex.Name = "vertex";
            this.vertex.Size = new System.Drawing.Size(84, 46);
            this.vertex.TabIndex = 2;
            this.vertex.Text = "добавить\r\nвершину";
            this.vertex.UseVisualStyleBackColor = true;
            this.vertex.Click += new System.EventHandler(this.vertex_Click);
            // 
            // edge
            // 
            this.edge.Location = new System.Drawing.Point(204, 370);
            this.edge.Name = "edge";
            this.edge.Size = new System.Drawing.Size(84, 45);
            this.edge.TabIndex = 3;
            this.edge.Text = "добавить\r\nребро";
            this.edge.UseVisualStyleBackColor = true;
            this.edge.Click += new System.EventHandler(this.edge_Click);
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(24, 369);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(84, 46);
            this.view.TabIndex = 4;
            this.view.Text = "обзор";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // dfs
            // 
            this.dfs.Location = new System.Drawing.Point(564, 371);
            this.dfs.Name = "dfs";
            this.dfs.Size = new System.Drawing.Size(84, 45);
            this.dfs.TabIndex = 5;
            this.dfs.Text = "DFS";
            this.dfs.UseVisualStyleBackColor = true;
            this.dfs.Click += new System.EventHandler(this.dfs_Click);
            // 
            // delVertex
            // 
            this.delVertex.Location = new System.Drawing.Point(294, 370);
            this.delVertex.Name = "delVertex";
            this.delVertex.Size = new System.Drawing.Size(84, 45);
            this.delVertex.TabIndex = 6;
            this.delVertex.Text = "удалить\r\nвершину";
            this.delVertex.UseVisualStyleBackColor = true;
            this.delVertex.Click += new System.EventHandler(this.delVertex_Click);
            // 
            // delEdge
            // 
            this.delEdge.Location = new System.Drawing.Point(384, 370);
            this.delEdge.Name = "delEdge";
            this.delEdge.Size = new System.Drawing.Size(84, 45);
            this.delEdge.TabIndex = 7;
            this.delEdge.Text = "удалить\r\nребро";
            this.delEdge.UseVisualStyleBackColor = true;
            this.delEdge.Click += new System.EventHandler(this.delEdge_Click);
            // 
            // delGraph
            // 
            this.delGraph.Location = new System.Drawing.Point(474, 371);
            this.delGraph.Name = "delGraph";
            this.delGraph.Size = new System.Drawing.Size(84, 45);
            this.delGraph.TabIndex = 8;
            this.delGraph.Text = "удалить\r\nграф";
            this.delGraph.UseVisualStyleBackColor = true;
            this.delGraph.Click += new System.EventHandler(this.delGraph_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.changeToolStripMenuItem,
            this.serviceToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(15, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(859, 24);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "&Файл";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Вы&ход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
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
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.параметрыToolStripMenuItem});
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.serviceToolStripMenuItem.Text = "&Сервис";
            this.serviceToolStripMenuItem.Click += new System.EventHandler(this.serviceToolStripMenuItem_Click);
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
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
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
            // saveFile
            // 
            this.saveFile.BackColor = System.Drawing.SystemColors.Control;
            this.saveFile.Image = ((System.Drawing.Image)(resources.GetObject("saveFile.Image")));
            this.saveFile.Location = new System.Drawing.Point(24, 24);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(23, 20);
            this.saveFile.TabIndex = 10;
            this.saveFile.UseVisualStyleBackColor = false;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // back
            // 
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(53, 24);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(23, 20);
            this.back.TabIndex = 11;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // forward
            // 
            this.forward.Image = ((System.Drawing.Image)(resources.GetObject("forward.Image")));
            this.forward.Location = new System.Drawing.Point(85, 24);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(23, 20);
            this.forward.TabIndex = 12;
            this.forward.UseVisualStyleBackColor = true;
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(859, 428);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.back);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.delGraph);
            this.Controls.Add(this.delEdge);
            this.Controls.Add(this.delVertex);
            this.Controls.Add(this.dfs);
            this.Controls.Add(this.view);
            this.Controls.Add(this.edge);
            this.Controls.Add(this.vertex);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button vertex;
        private System.Windows.Forms.Button edge;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button dfs;
        private System.Windows.Forms.Button delVertex;
        private System.Windows.Forms.Button delEdge;
        private System.Windows.Forms.Button delGraph;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aProgrammToolStripMenuItem;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменадействияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменадействияToolStripMenuItem1;
    }
}

