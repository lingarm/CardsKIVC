namespace CardsKIVC
{
    partial class CardsKIVC
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Container = new System.Windows.Forms.SplitContainer();
            this.CardsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Container)).BeginInit();
            this.Container.Panel2.SuspendLayout();
            this.Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Container.Location = new System.Drawing.Point(12, 39);
            this.Container.Name = "Container";
            // 
            // Container.Panel1
            // 
            this.Container.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // Container.Panel2
            // 
            this.Container.Panel2.Controls.Add(this.CardsGridView);
            this.Container.Size = new System.Drawing.Size(623, 313);
            this.Container.SplitterDistance = 161;
            this.Container.TabIndex = 3;
            // 
            // CardsGridView
            // 
            this.CardsGridView.AllowUserToAddRows = false;
            this.CardsGridView.AllowUserToDeleteRows = false;
            this.CardsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CardsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CardsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CardsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardsGridView.Location = new System.Drawing.Point(0, 0);
            this.CardsGridView.Name = "CardsGridView";
            this.CardsGridView.ReadOnly = true;
            this.CardsGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CardsGridView.Size = new System.Drawing.Size(458, 313);
            this.CardsGridView.TabIndex = 0;
            this.CardsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CardsGridView_CellDoubleClick);
            // 
            // CardsKIVC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 364);
            this.Controls.Add(this.Container);
            this.Name = "CardsKIVC";
            this.Text = "CardsKIVC";
            this.Load += new System.EventHandler(this.CardsKIVC_Load);
            this.Container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Container)).EndInit();
            this.Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CardsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Container;
        internal System.Windows.Forms.DataGridView CardsGridView;
    }
}

