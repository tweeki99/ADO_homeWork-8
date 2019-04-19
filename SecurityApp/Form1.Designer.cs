using System.Windows.Forms;

namespace SecurityApp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ButtonAddVisitor = new System.Windows.Forms.Button();
            this.DataGridViewVisitors = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVisitors)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonAddVisitor
            // 
            this.ButtonAddVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddVisitor.Location = new System.Drawing.Point(12, 376);
            this.ButtonAddVisitor.Name = "ButtonAddVisitor";
            this.ButtonAddVisitor.Size = new System.Drawing.Size(335, 62);
            this.ButtonAddVisitor.TabIndex = 0;
            this.ButtonAddVisitor.Text = "Новый посетитель";
            this.ButtonAddVisitor.UseVisualStyleBackColor = true;
            this.ButtonAddVisitor.Click += new System.EventHandler(this.ButtonAddVisitorClick);
            // 
            // DataGridViewVisitors
            // 
            this.DataGridViewVisitors.AllowUserToAddRows = false;
            this.DataGridViewVisitors.AllowUserToDeleteRows = false;
            this.DataGridViewVisitors.AllowUserToResizeColumns = false;
            this.DataGridViewVisitors.AllowUserToResizeRows = false;
            this.DataGridViewVisitors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewVisitors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewVisitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewVisitors.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewVisitors.EnableHeadersVisualStyles = false;
            this.DataGridViewVisitors.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataGridViewVisitors.Location = new System.Drawing.Point(12, 12);
            this.DataGridViewVisitors.MultiSelect = false;
            this.DataGridViewVisitors.Name = "DataGridViewVisitors";
            this.DataGridViewVisitors.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewVisitors.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewVisitors.RowHeadersVisible = false;
            this.DataGridViewVisitors.RowTemplate.Height = 40;
            this.DataGridViewVisitors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewVisitors.Size = new System.Drawing.Size(573, 358);
            this.DataGridViewVisitors.TabIndex = 15;
            this.DataGridViewVisitors.SelectionChanged += new System.EventHandler(this.DataGridViewVisitorsSelectionChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(596, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(192, 329);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(591, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Цель посещения";
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonExit.Location = new System.Drawing.Point(462, 376);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(326, 62);
            this.ButtonExit.TabIndex = 18;
            this.ButtonExit.Text = "Покинул здание";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.DataGridViewVisitors);
            this.Controls.Add(this.ButtonAddVisitor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVisitors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddVisitor;
        private System.Windows.Forms.DataGridView DataGridViewVisitors;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private Button ButtonExit;
    }
}

