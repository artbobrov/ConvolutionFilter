
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.HBox hbox1;

	private global::Gtk.VBox vbox1;

	private global::Gtk.HBox hbox3;

	private global::Gtk.HBox hbox5;

	private global::Gtk.Label chooseImageLabel;

	private global::Gtk.Button chooseImageButton;

	private global::Gtk.HBox hbox7;

	private global::Gtk.HBox hbox9;

	private global::Gtk.Label filterLabel;

	private global::Gtk.ComboBox filterComboBox;

	private global::Gtk.HBox hbox11;

	private global::Gtk.Label threadCountLabel;

	private global::Gtk.SpinButton threadCountSpin;

	private global::Gtk.Button actionButton;

	private global::Gtk.HSeparator hseparator3;

	private global::Gtk.VBox vbox5;

	private global::Gtk.HBox hbox2;

	private global::Gtk.ScrolledWindow originalScrolledwindow;

	private global::Gtk.Image originalImage;

	private global::Gtk.VSeparator vseparator1;

	private global::Gtk.ScrolledWindow filteredScrollWindow;

	private global::Gtk.Image filteredImage;

	private global::Gtk.HSeparator hseparator1;

	private global::Gtk.HBox hbox13;

	private global::Gtk.HPaned hpaned6;

	private global::Gtk.Label informationLabel;

	private global::Gtk.HPaned hpaned8;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		this.vbox1.BorderWidth = ((uint)(6));
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.chooseImageLabel = new global::Gtk.Label();
		this.chooseImageLabel.Name = "chooseImageLabel";
		this.chooseImageLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Choose Image");
		this.hbox5.Add(this.chooseImageLabel);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.chooseImageLabel]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox5.Gtk.Box+BoxChild
		this.chooseImageButton = new global::Gtk.Button();
		this.chooseImageButton.CanFocus = true;
		this.chooseImageButton.Name = "chooseImageButton";
		this.chooseImageButton.UseUnderline = true;
		global::Gtk.Image w2 = new global::Gtk.Image();
		w2.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-open", global::Gtk.IconSize.Button);
		this.chooseImageButton.Image = w2;
		this.hbox5.Add(this.chooseImageButton);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.chooseImageButton]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		this.hbox3.Add(this.hbox5);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.hbox5]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.hbox7 = new global::Gtk.HBox();
		this.hbox7.Name = "hbox7";
		this.hbox7.Spacing = 6;
		// Container child hbox7.Gtk.Box+BoxChild
		this.hbox9 = new global::Gtk.HBox();
		this.hbox9.Name = "hbox9";
		this.hbox9.Spacing = 6;
		// Container child hbox9.Gtk.Box+BoxChild
		this.filterLabel = new global::Gtk.Label();
		this.filterLabel.Name = "filterLabel";
		this.filterLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Choose Filter");
		this.hbox9.Add(this.filterLabel);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.filterLabel]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child hbox9.Gtk.Box+BoxChild
		this.filterComboBox = global::Gtk.ComboBox.NewText();
		this.filterComboBox.Name = "filterComboBox";
		this.hbox9.Add(this.filterComboBox);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.filterComboBox]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child hbox9.Gtk.Box+BoxChild
		this.hbox11 = new global::Gtk.HBox();
		this.hbox11.Name = "hbox11";
		this.hbox11.Spacing = 6;
		// Container child hbox11.Gtk.Box+BoxChild
		this.threadCountLabel = new global::Gtk.Label();
		this.threadCountLabel.Name = "threadCountLabel";
		this.threadCountLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Thread Count");
		this.hbox11.Add(this.threadCountLabel);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.threadCountLabel]));
		w7.Position = 0;
		w7.Expand = false;
		w7.Fill = false;
		// Container child hbox11.Gtk.Box+BoxChild
		this.threadCountSpin = new global::Gtk.SpinButton(2D, 100D, 1D);
		this.threadCountSpin.CanFocus = true;
		this.threadCountSpin.Name = "threadCountSpin";
		this.threadCountSpin.Adjustment.PageIncrement = 1D;
		this.threadCountSpin.ClimbRate = 1D;
		this.threadCountSpin.Numeric = true;
		this.threadCountSpin.Value = 2D;
		this.hbox11.Add(this.threadCountSpin);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.threadCountSpin]));
		w8.Position = 1;
		w8.Expand = false;
		w8.Fill = false;
		this.hbox9.Add(this.hbox11);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.hbox11]));
		w9.Position = 2;
		this.hbox7.Add(this.hbox9);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.hbox9]));
		w10.Position = 0;
		this.hbox3.Add(this.hbox7);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.hbox7]));
		w11.Position = 1;
		// Container child hbox3.Gtk.Box+BoxChild
		this.actionButton = new global::Gtk.Button();
		this.actionButton.CanFocus = true;
		this.actionButton.Name = "actionButton";
		this.actionButton.UseUnderline = true;
		this.actionButton.Label = global::Mono.Unix.Catalog.GetString("Apply filter");
		this.hbox3.Add(this.actionButton);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.actionButton]));
		w12.Position = 2;
		w12.Expand = false;
		w12.Fill = false;
		this.vbox1.Add(this.hbox3);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox3]));
		w13.Position = 0;
		w13.Expand = false;
		w13.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hseparator3 = new global::Gtk.HSeparator();
		this.hseparator3.Name = "hseparator3";
		this.vbox1.Add(this.hseparator3);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hseparator3]));
		w14.Position = 1;
		w14.Expand = false;
		w14.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.vbox5 = new global::Gtk.VBox();
		this.vbox5.Name = "vbox5";
		this.vbox5.Spacing = 6;
		// Container child vbox5.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.originalScrolledwindow = new global::Gtk.ScrolledWindow();
		this.originalScrolledwindow.CanFocus = true;
		this.originalScrolledwindow.Name = "originalScrolledwindow";
		this.originalScrolledwindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child originalScrolledwindow.Gtk.Container+ContainerChild
		global::Gtk.Viewport w15 = new global::Gtk.Viewport();
		w15.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child GtkViewport1.Gtk.Container+ContainerChild
		this.originalImage = new global::Gtk.Image();
		this.originalImage.Name = "originalImage";
		w15.Add(this.originalImage);
		this.originalScrolledwindow.Add(w15);
		this.hbox2.Add(this.originalScrolledwindow);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.originalScrolledwindow]));
		w18.Position = 0;
		// Container child hbox2.Gtk.Box+BoxChild
		this.vseparator1 = new global::Gtk.VSeparator();
		this.vseparator1.Name = "vseparator1";
		this.hbox2.Add(this.vseparator1);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vseparator1]));
		w19.Position = 1;
		w19.Expand = false;
		w19.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.filteredScrollWindow = new global::Gtk.ScrolledWindow();
		this.filteredScrollWindow.CanFocus = true;
		this.filteredScrollWindow.Name = "filteredScrollWindow";
		this.filteredScrollWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child filteredScrollWindow.Gtk.Container+ContainerChild
		global::Gtk.Viewport w20 = new global::Gtk.Viewport();
		w20.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child GtkViewport.Gtk.Container+ContainerChild
		this.filteredImage = new global::Gtk.Image();
		this.filteredImage.Name = "filteredImage";
		w20.Add(this.filteredImage);
		this.filteredScrollWindow.Add(w20);
		this.hbox2.Add(this.filteredScrollWindow);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.filteredScrollWindow]));
		w23.Position = 2;
		this.vbox5.Add(this.hbox2);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox2]));
		w24.Position = 0;
		// Container child vbox5.Gtk.Box+BoxChild
		this.hseparator1 = new global::Gtk.HSeparator();
		this.hseparator1.Name = "hseparator1";
		this.vbox5.Add(this.hseparator1);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hseparator1]));
		w25.Position = 1;
		w25.Expand = false;
		w25.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.hbox13 = new global::Gtk.HBox();
		this.hbox13.Name = "hbox13";
		this.hbox13.Spacing = 6;
		// Container child hbox13.Gtk.Box+BoxChild
		this.hpaned6 = new global::Gtk.HPaned();
		this.hpaned6.CanFocus = true;
		this.hpaned6.Name = "hpaned6";
		this.hpaned6.Position = 10;
		this.hbox13.Add(this.hpaned6);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox13[this.hpaned6]));
		w26.Position = 0;
		// Container child hbox13.Gtk.Box+BoxChild
		this.informationLabel = new global::Gtk.Label();
		this.informationLabel.Name = "informationLabel";
		this.informationLabel.LabelProp = "";
		this.informationLabel.Justify = ((global::Gtk.Justification)(2));
		this.hbox13.Add(this.informationLabel);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox13[this.informationLabel]));
		w27.Position = 1;
		w27.Expand = false;
		w27.Fill = false;
		// Container child hbox13.Gtk.Box+BoxChild
		this.hpaned8 = new global::Gtk.HPaned();
		this.hpaned8.CanFocus = true;
		this.hpaned8.Name = "hpaned8";
		this.hpaned8.Position = 10;
		this.hbox13.Add(this.hpaned8);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox13[this.hpaned8]));
		w28.Position = 2;
		this.vbox5.Add(this.hbox13);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox13]));
		w29.Position = 2;
		w29.Expand = false;
		w29.Fill = false;
		this.vbox1.Add(this.vbox5);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vbox5]));
		w30.Position = 2;
		this.hbox1.Add(this.vbox1);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox1]));
		w31.Position = 0;
		this.Add(this.hbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 807;
		this.DefaultHeight = 603;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.chooseImageButton.Clicked += new global::System.EventHandler(this.OpenButtonClicked);
		this.actionButton.Clicked += new global::System.EventHandler(this.ProcessButton);
	}
}
