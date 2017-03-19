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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vertex = new System.Windows.Forms.Button();
            this.edge = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.dfs = new System.Windows.Forms.Button();
            this.delVertex = new System.Windows.Forms.Button();
            this.delEdge = new System.Windows.Forms.Button();
            this.delGraph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(807, 345);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 428);
            this.Controls.Add(this.delGraph);
            this.Controls.Add(this.delEdge);
            this.Controls.Add(this.delVertex);
            this.Controls.Add(this.dfs);
            this.Controls.Add(this.view);
            this.Controls.Add(this.edge);
            this.Controls.Add(this.vertex);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

