namespace QueryLINQ
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
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtWhere = new System.Windows.Forms.TextBox();
            this.btnWhere = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnStartsWith = new System.Windows.Forms.Button();
            this.btnEndsWith = new System.Windows.Forms.Button();
            this.btnOrderByASC = new System.Windows.Forms.Button();
            this.btnOrderByDSC = new System.Windows.Forms.Button();
            this.btnGroupBy = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.txtContains = new System.Windows.Forms.TextBox();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.txtEquals = new System.Windows.Forms.TextBox();
            this.btnJoin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(12, 12);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.Size = new System.Drawing.Size(343, 237);
            this.dgvDisplay.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(361, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtWhere
            // 
            this.txtWhere.Location = new System.Drawing.Point(442, 12);
            this.txtWhere.Name = "txtWhere";
            this.txtWhere.Size = new System.Drawing.Size(156, 20);
            this.txtWhere.TabIndex = 2;
            // 
            // btnWhere
            // 
            this.btnWhere.Location = new System.Drawing.Point(604, 12);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(75, 23);
            this.btnWhere.TabIndex = 3;
            this.btnWhere.Text = "Where";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(361, 54);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 23);
            this.btnSum.TabIndex = 4;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(442, 54);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(75, 23);
            this.btnMax.TabIndex = 5;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(523, 54);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(75, 23);
            this.btnMin.TabIndex = 6;
            this.btnMin.Text = "Min";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(604, 54);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(75, 23);
            this.btnAverage.TabIndex = 7;
            this.btnAverage.Text = "Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(361, 95);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(75, 23);
            this.btnTake.TabIndex = 8;
            this.btnTake.Text = "Take";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(442, 95);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(75, 23);
            this.btnSkip.TabIndex = 9;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnStartsWith
            // 
            this.btnStartsWith.Location = new System.Drawing.Point(523, 95);
            this.btnStartsWith.Name = "btnStartsWith";
            this.btnStartsWith.Size = new System.Drawing.Size(75, 23);
            this.btnStartsWith.TabIndex = 10;
            this.btnStartsWith.Text = "StartsWith";
            this.btnStartsWith.UseVisualStyleBackColor = true;
            this.btnStartsWith.Click += new System.EventHandler(this.btnStartsWith_Click);
            // 
            // btnEndsWith
            // 
            this.btnEndsWith.Location = new System.Drawing.Point(604, 95);
            this.btnEndsWith.Name = "btnEndsWith";
            this.btnEndsWith.Size = new System.Drawing.Size(75, 23);
            this.btnEndsWith.TabIndex = 11;
            this.btnEndsWith.Text = "EndsWith";
            this.btnEndsWith.UseVisualStyleBackColor = true;
            this.btnEndsWith.Click += new System.EventHandler(this.btnEndsWith_Click);
            // 
            // btnOrderByASC
            // 
            this.btnOrderByASC.Location = new System.Drawing.Point(361, 136);
            this.btnOrderByASC.Name = "btnOrderByASC";
            this.btnOrderByASC.Size = new System.Drawing.Size(117, 23);
            this.btnOrderByASC.TabIndex = 12;
            this.btnOrderByASC.Text = "OrderByASC";
            this.btnOrderByASC.UseVisualStyleBackColor = true;
            this.btnOrderByASC.Click += new System.EventHandler(this.btnOrderByASC_Click);
            // 
            // btnOrderByDSC
            // 
            this.btnOrderByDSC.Location = new System.Drawing.Point(484, 136);
            this.btnOrderByDSC.Name = "btnOrderByDSC";
            this.btnOrderByDSC.Size = new System.Drawing.Size(114, 23);
            this.btnOrderByDSC.TabIndex = 13;
            this.btnOrderByDSC.Text = "OrderByDSC";
            this.btnOrderByDSC.UseVisualStyleBackColor = true;
            this.btnOrderByDSC.Click += new System.EventHandler(this.btnOrderByDSC_Click);
            // 
            // btnGroupBy
            // 
            this.btnGroupBy.Location = new System.Drawing.Point(604, 136);
            this.btnGroupBy.Name = "btnGroupBy";
            this.btnGroupBy.Size = new System.Drawing.Size(75, 23);
            this.btnGroupBy.TabIndex = 14;
            this.btnGroupBy.Text = "GroupBy";
            this.btnGroupBy.UseVisualStyleBackColor = true;
            this.btnGroupBy.Click += new System.EventHandler(this.btnGroupBy_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(361, 176);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 15;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(442, 176);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(120, 23);
            this.btnFirst.TabIndex = 16;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(568, 176);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(111, 23);
            this.btnLast.TabIndex = 17;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // txtContains
            // 
            this.txtContains.Location = new System.Drawing.Point(361, 205);
            this.txtContains.Name = "txtContains";
            this.txtContains.Size = new System.Drawing.Size(75, 20);
            this.txtContains.TabIndex = 18;
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(442, 203);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(75, 23);
            this.btnContains.TabIndex = 19;
            this.btnContains.Text = "Contains";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(604, 206);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(78, 23);
            this.btnEquals.TabIndex = 21;
            this.btnEquals.Text = "Equals";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // txtEquals
            // 
            this.txtEquals.Location = new System.Drawing.Point(523, 206);
            this.txtEquals.Name = "txtEquals";
            this.txtEquals.Size = new System.Drawing.Size(75, 20);
            this.txtEquals.TabIndex = 20;
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(361, 231);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(78, 23);
            this.btnJoin.TabIndex = 22;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 264);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.txtEquals);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.txtContains);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnGroupBy);
            this.Controls.Add(this.btnOrderByDSC);
            this.Controls.Add(this.btnOrderByASC);
            this.Controls.Add(this.btnEndsWith);
            this.Controls.Add(this.btnStartsWith);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.txtWhere);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dgvDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtWhere;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnStartsWith;
        private System.Windows.Forms.Button btnEndsWith;
        private System.Windows.Forms.Button btnOrderByASC;
        private System.Windows.Forms.Button btnOrderByDSC;
        private System.Windows.Forms.Button btnGroupBy;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.TextBox txtContains;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.TextBox txtEquals;
        private System.Windows.Forms.Button btnJoin;
    }
}

