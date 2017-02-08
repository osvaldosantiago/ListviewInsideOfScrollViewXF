using Xamarin.Forms;

namespace ListviewInsideOfScrollViewXF
{
	public partial class ListviewInsideOfScrollViewXFPage : ContentPage
	{
		DataVm ViewModel;
		public ListviewInsideOfScrollViewXFPage()
		{
			InitializeComponent();
			ViewModel = new DataVm();
			BindingContext = ViewModel;

			myListView.SeparatorColor = Color.Gray;
			myListView.SetBinding(ListView.ItemsSourceProperty, ViewModel.BindTo(x => x.DataItems));
			myListView.ItemTemplate = new DataTemplate(CreateCell);


		}
		Cell CreateCell()
		{
			var view = new CustomViewCell() { };
			var cell = new ViewCell();
			cell.View = view;
			cell.Height = 100;
			return cell;
		}
	}
}
