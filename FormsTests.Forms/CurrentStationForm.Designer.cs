namespace FormsTests;

partial class CurrentStationForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        currentStationHolder = new System.Windows.Forms.FlowLayoutPanel();
        tracksCount = new System.Windows.Forms.NumericUpDown();
        platformsCount = new System.Windows.Forms.NumericUpDown();
        sectorsCountsHolder = new System.Windows.Forms.FlowLayoutPanel();
        sectorsStartingLabelsHolder = new System.Windows.Forms.FlowLayoutPanel();
        trackLabelsHolder = new System.Windows.Forms.FlowLayoutPanel();
        platformLabelsHolder = new System.Windows.Forms.FlowLayoutPanel();
        stationName = new System.Windows.Forms.NumericUpDown();
        stationStructure = new System.Windows.Forms.CheckedListBox();
        button1 = new System.Windows.Forms.Button();
        currentStationHolder.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)tracksCount).BeginInit();
        ((System.ComponentModel.ISupportInitialize)platformsCount).BeginInit();
        ((System.ComponentModel.ISupportInitialize)stationName).BeginInit();
        SuspendLayout();
        // 
        // currentStationHolder
        // 
        currentStationHolder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        currentStationHolder.AutoSize = true;
        currentStationHolder.Controls.Add(tracksCount);
        currentStationHolder.Controls.Add(platformsCount);
        currentStationHolder.Controls.Add(sectorsCountsHolder);
        currentStationHolder.Controls.Add(sectorsStartingLabelsHolder);
        currentStationHolder.Controls.Add(trackLabelsHolder);
        currentStationHolder.Controls.Add(platformLabelsHolder);
        currentStationHolder.Controls.Add(stationName);
        currentStationHolder.Controls.Add(stationStructure);
        currentStationHolder.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
        currentStationHolder.Location = new System.Drawing.Point(15, 15);
        currentStationHolder.Margin = new System.Windows.Forms.Padding(4);
        currentStationHolder.Name = "currentStationHolder";
        currentStationHolder.Size = new System.Drawing.Size(896, 734);
        currentStationHolder.TabIndex = 0;
        // 
        // tracksCount
        // 
        tracksCount.Location = new System.Drawing.Point(4, 4);
        tracksCount.Margin = new System.Windows.Forms.Padding(4);
        tracksCount.Name = "tracksCount";
        tracksCount.Size = new System.Drawing.Size(154, 27);
        tracksCount.TabIndex = 0;
        tracksCount.ValueChanged += TracksCountKeyDown;
        tracksCount.PreviewKeyDown += TracksCountKeyDown;
        // 
        // platformsCount
        // 
        platformsCount.Location = new System.Drawing.Point(4, 39);
        platformsCount.Margin = new System.Windows.Forms.Padding(4);
        platformsCount.Name = "platformsCount";
        platformsCount.Size = new System.Drawing.Size(154, 27);
        platformsCount.TabIndex = 1;
        platformsCount.ValueChanged += PlatformsCountKeyDown;
        platformsCount.PreviewKeyDown += PlatformsCountKeyDown;
        // 
        // sectorsCountsHolder
        // 
        sectorsCountsHolder.Location = new System.Drawing.Point(4, 74);
        sectorsCountsHolder.Margin = new System.Windows.Forms.Padding(4);
        sectorsCountsHolder.Name = "sectorsCountsHolder";
        sectorsCountsHolder.Size = new System.Drawing.Size(257, 127);
        sectorsCountsHolder.TabIndex = 2;
        // 
        // sectorsStartingLabelsHolder
        // 
        sectorsStartingLabelsHolder.Location = new System.Drawing.Point(4, 209);
        sectorsStartingLabelsHolder.Margin = new System.Windows.Forms.Padding(4);
        sectorsStartingLabelsHolder.Name = "sectorsStartingLabelsHolder";
        sectorsStartingLabelsHolder.Size = new System.Drawing.Size(257, 127);
        sectorsStartingLabelsHolder.TabIndex = 3;
        // 
        // trackLabelsHolder
        // 
        trackLabelsHolder.Location = new System.Drawing.Point(4, 344);
        trackLabelsHolder.Margin = new System.Windows.Forms.Padding(4);
        trackLabelsHolder.Name = "trackLabelsHolder";
        trackLabelsHolder.Size = new System.Drawing.Size(257, 127);
        trackLabelsHolder.TabIndex = 4;
        // 
        // platformLabelsHolder
        // 
        platformLabelsHolder.Location = new System.Drawing.Point(4, 479);
        platformLabelsHolder.Margin = new System.Windows.Forms.Padding(4);
        platformLabelsHolder.Name = "platformLabelsHolder";
        platformLabelsHolder.Size = new System.Drawing.Size(257, 127);
        platformLabelsHolder.TabIndex = 5;
        // 
        // stationName
        // 
        stationName.Location = new System.Drawing.Point(4, 614);
        stationName.Margin = new System.Windows.Forms.Padding(4);
        stationName.Name = "stationName";
        stationName.Size = new System.Drawing.Size(154, 27);
        stationName.TabIndex = 7;
        // 
        // stationStructure
        // 
        stationStructure.FormattingEnabled = true;
        stationStructure.Items.AddRange(new object[] { "Podchod", "Úrovňové přechody", "Nadchod", "Provizorní přechod" });
        stationStructure.Location = new System.Drawing.Point(269, 4);
        stationStructure.Margin = new System.Windows.Forms.Padding(4);
        stationStructure.Name = "stationStructure";
        stationStructure.Size = new System.Drawing.Size(210, 92);
        stationStructure.TabIndex = 8;
        // 
        // button1
        // 
        button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        button1.Location = new System.Drawing.Point(428, 756);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(75, 37);
        button1.TabIndex = 1;
        button1.Text = "Save";
        button1.UseVisualStyleBackColor = true;
        button1.Click += Button_Save;
        // 
        // CurrentStationForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        ClientSize = new System.Drawing.Size(927, 803);
        Controls.Add(button1);
        Controls.Add(currentStationHolder);
        Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        Margin = new System.Windows.Forms.Padding(4);
        Name = "CurrentStationForm";
        Text = "Form1";
        currentStationHolder.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)tracksCount).EndInit();
        ((System.ComponentModel.ISupportInitialize)platformsCount).EndInit();
        ((System.ComponentModel.ISupportInitialize)stationName).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.FlowLayoutPanel currentStationHolder;
    private System.Windows.Forms.NumericUpDown tracksCount;
    private System.Windows.Forms.NumericUpDown platformsCount;
    private System.Windows.Forms.FlowLayoutPanel sectorsCountsHolder;
    private System.Windows.Forms.FlowLayoutPanel sectorsStartingLabelsHolder;
    private System.Windows.Forms.FlowLayoutPanel trackLabelsHolder;
    private System.Windows.Forms.FlowLayoutPanel platformLabelsHolder;
    private System.Windows.Forms.NumericUpDown stationName;
    private System.Windows.Forms.CheckedListBox stationStructure;
    private System.Windows.Forms.Button button1;
}
