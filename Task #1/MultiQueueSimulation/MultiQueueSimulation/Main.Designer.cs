﻿namespace MultiQueueSimulation
{
    partial class Main
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
            this.openTestCaseButton = new System.Windows.Forms.Button();
            this.testCaseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.numberOfServersLabel = new System.Windows.Forms.Label();
            this.stoppingNumberLabel = new System.Windows.Forms.Label();
            this.stoppingCriteriaLabel = new System.Windows.Forms.Label();
            this.selectionMethodLabel = new System.Windows.Forms.Label();
            this.numberOfServersTextBox = new System.Windows.Forms.TextBox();
            this.stoppingNumberTextBox = new System.Windows.Forms.TextBox();
            this.stoppingCriteriaTextBox = new System.Windows.Forms.TextBox();
            this.selectionMethodTextBox = new System.Windows.Forms.TextBox();
            this.interarrivalDistributionDataTable = new System.Windows.Forms.DataGridView();
            this.interarrivalTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.interarrivalDistributionDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // openTestCaseButton
            // 
            this.openTestCaseButton.Location = new System.Drawing.Point(58, 298);
            this.openTestCaseButton.Name = "openTestCaseButton";
            this.openTestCaseButton.Size = new System.Drawing.Size(75, 42);
            this.openTestCaseButton.TabIndex = 0;
            this.openTestCaseButton.Text = "Open TestCase";
            this.openTestCaseButton.UseVisualStyleBackColor = true;
            this.openTestCaseButton.Click += new System.EventHandler(this.openTestCaseButton_Click);
            // 
            // numberOfServersLabel
            // 
            this.numberOfServersLabel.AutoSize = true;
            this.numberOfServersLabel.Location = new System.Drawing.Point(169, 297);
            this.numberOfServersLabel.Name = "numberOfServersLabel";
            this.numberOfServersLabel.Size = new System.Drawing.Size(99, 13);
            this.numberOfServersLabel.TabIndex = 1;
            this.numberOfServersLabel.Text = "Number Of Servers";
            // 
            // stoppingNumberLabel
            // 
            this.stoppingNumberLabel.AutoSize = true;
            this.stoppingNumberLabel.Location = new System.Drawing.Point(325, 297);
            this.stoppingNumberLabel.Name = "stoppingNumberLabel";
            this.stoppingNumberLabel.Size = new System.Drawing.Size(89, 13);
            this.stoppingNumberLabel.TabIndex = 2;
            this.stoppingNumberLabel.Text = "Stopping Number";
            // 
            // stoppingCriteriaLabel
            // 
            this.stoppingCriteriaLabel.AutoSize = true;
            this.stoppingCriteriaLabel.Location = new System.Drawing.Point(465, 297);
            this.stoppingCriteriaLabel.Name = "stoppingCriteriaLabel";
            this.stoppingCriteriaLabel.Size = new System.Drawing.Size(87, 13);
            this.stoppingCriteriaLabel.TabIndex = 3;
            this.stoppingCriteriaLabel.Text = "Stopping Criteria";
            // 
            // selectionMethodLabel
            // 
            this.selectionMethodLabel.AutoSize = true;
            this.selectionMethodLabel.Location = new System.Drawing.Point(600, 297);
            this.selectionMethodLabel.Name = "selectionMethodLabel";
            this.selectionMethodLabel.Size = new System.Drawing.Size(89, 13);
            this.selectionMethodLabel.TabIndex = 4;
            this.selectionMethodLabel.Text = "Selection Method";
            // 
            // numberOfServersTextBox
            // 
            this.numberOfServersTextBox.Location = new System.Drawing.Point(172, 320);
            this.numberOfServersTextBox.Name = "numberOfServersTextBox";
            this.numberOfServersTextBox.Size = new System.Drawing.Size(92, 20);
            this.numberOfServersTextBox.TabIndex = 5;
            // 
            // stoppingNumberTextBox
            // 
            this.stoppingNumberTextBox.Location = new System.Drawing.Point(328, 320);
            this.stoppingNumberTextBox.Name = "stoppingNumberTextBox";
            this.stoppingNumberTextBox.Size = new System.Drawing.Size(86, 20);
            this.stoppingNumberTextBox.TabIndex = 6;
            // 
            // stoppingCriteriaTextBox
            // 
            this.stoppingCriteriaTextBox.Location = new System.Drawing.Point(456, 320);
            this.stoppingCriteriaTextBox.Name = "stoppingCriteriaTextBox";
            this.stoppingCriteriaTextBox.Size = new System.Drawing.Size(107, 20);
            this.stoppingCriteriaTextBox.TabIndex = 7;
            // 
            // selectionMethodTextBox
            // 
            this.selectionMethodTextBox.Location = new System.Drawing.Point(603, 320);
            this.selectionMethodTextBox.Name = "selectionMethodTextBox";
            this.selectionMethodTextBox.Size = new System.Drawing.Size(92, 20);
            this.selectionMethodTextBox.TabIndex = 8;
            // 
            // interarrivalDistributionDataTable
            // 
            this.interarrivalDistributionDataTable.AllowUserToAddRows = false;
            this.interarrivalDistributionDataTable.AllowUserToDeleteRows = false;
            this.interarrivalDistributionDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.interarrivalDistributionDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.interarrivalTimeColumn,
            this.probabilityColumn});
            this.interarrivalDistributionDataTable.Location = new System.Drawing.Point(58, 30);
            this.interarrivalDistributionDataTable.Name = "interarrivalDistributionDataTable";
            this.interarrivalDistributionDataTable.ReadOnly = true;
            this.interarrivalDistributionDataTable.Size = new System.Drawing.Size(243, 252);
            this.interarrivalDistributionDataTable.TabIndex = 9;
            // 
            // interarrivalTimeColumn
            // 
            this.interarrivalTimeColumn.HeaderText = "Interarrival Time";
            this.interarrivalTimeColumn.Name = "interarrivalTimeColumn";
            this.interarrivalTimeColumn.ReadOnly = true;
            // 
            // probabilityColumn
            // 
            this.probabilityColumn.HeaderText = "Probability";
            this.probabilityColumn.Name = "probabilityColumn";
            this.probabilityColumn.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 352);
            this.Controls.Add(this.interarrivalDistributionDataTable);
            this.Controls.Add(this.selectionMethodTextBox);
            this.Controls.Add(this.stoppingCriteriaTextBox);
            this.Controls.Add(this.stoppingNumberTextBox);
            this.Controls.Add(this.numberOfServersTextBox);
            this.Controls.Add(this.selectionMethodLabel);
            this.Controls.Add(this.stoppingCriteriaLabel);
            this.Controls.Add(this.stoppingNumberLabel);
            this.Controls.Add(this.numberOfServersLabel);
            this.Controls.Add(this.openTestCaseButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.interarrivalDistributionDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openTestCaseButton;
        private System.Windows.Forms.OpenFileDialog testCaseFileDialog;
        private System.Windows.Forms.Label numberOfServersLabel;
        private System.Windows.Forms.Label stoppingNumberLabel;
        private System.Windows.Forms.Label stoppingCriteriaLabel;
        private System.Windows.Forms.Label selectionMethodLabel;
        private System.Windows.Forms.TextBox numberOfServersTextBox;
        private System.Windows.Forms.TextBox stoppingNumberTextBox;
        private System.Windows.Forms.TextBox stoppingCriteriaTextBox;
        private System.Windows.Forms.TextBox selectionMethodTextBox;
        private System.Windows.Forms.DataGridView interarrivalDistributionDataTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn interarrivalTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilityColumn;
    }
}

