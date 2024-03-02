namespace UseBank
{
    partial class HistoryOperations
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
            dataGridViewMain=new DataGridView();
            DateTime=new DataGridViewTextBoxColumn();
            Money=new DataGridViewTextBoxColumn();
            Operation=new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMain
            // 
            dataGridViewMain.BackgroundColor=Color.MediumPurple;
            dataGridViewMain.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMain.Columns.AddRange(new DataGridViewColumn[] { DateTime, Money, Operation });
            dataGridViewMain.GridColor=SystemColors.Control;
            dataGridViewMain.Location=new Point(12, 12);
            dataGridViewMain.Name="dataGridViewMain";
            dataGridViewMain.RowTemplate.Height=25;
            dataGridViewMain.Size=new Size(776, 426);
            dataGridViewMain.TabIndex=0;
            dataGridViewMain.CellContentClick+=dataGridViewMain_CellContentClick;
            // 
            // DateTime
            // 
            DateTime.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            DateTime.HeaderText="Дата и время";
            DateTime.Name="DateTime";
            // 
            // Money
            // 
            Money.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            Money.HeaderText="Монет";
            Money.Name="Money";
            // 
            // Operation
            // 
            Operation.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            Operation.HeaderText="Операция";
            Operation.Name="Operation";
            // 
            // HistoryOperations
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.MediumPurple;
            ClientSize=new Size(800, 450);
            Controls.Add(dataGridViewMain);
            ForeColor=Color.Indigo;
            FormBorderStyle=FormBorderStyle.FixedToolWindow;
            MaximumSize=new Size(816, 489);
            MinimumSize=new Size(816, 489);
            Name="HistoryOperations";
            StartPosition=FormStartPosition.CenterScreen;
            Text="История операций";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewMain;
        private DataGridViewTextBoxColumn DateTime;
        private DataGridViewTextBoxColumn Money;
        private DataGridViewTextBoxColumn Operation;
    }
}