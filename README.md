# TestApp
Simple App to test Win2D with WinUI3

What I want to do is to have some (~200) Win2D CanvasControl's in a scrollable ListView.
Since I know that I have to RemoveFromVisualtree each of the controls, I encapsulated them
in a UserControl.
but when the ListView Scrolls the bindings seem to get wird
I reduced the problem to the following
The Model has a List of 500 ModelItems (just a property Label)
I ve created two Usercontrols both with Binding the label; vboth report this label in two lines;
Win2DCtrl1 is a WinUI only solution (borh lines bind Label to a TextBox),
Win2DCtrl2 is close to the desired solution: the first line is a textbox (as above9, the second line
is drawn in a CanvasControl

Now, what's happening is: when the listview starts scrolling, line1 and line 2 show different values in Win2DCtrl2!

The simple TestApp shows a ListView with Win2DCtrl1 (works and the riht side a Listview with Win2DCtrl2 (out of sync after scrolling)

Q: What am I doing wrong
Q: Will this ever work with large lists?
