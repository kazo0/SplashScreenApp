using Uno.Toolkit;
using Uno.Toolkit.UI;

namespace SplashScreenApp;
public sealed partial class Shell : UserControl
{
	public ExtendedSplashScreen SplashScreen => Splash;
	public Frame RootFrame => ShellFrame;

	private MyLoadableSource _loadable = new();

	public Shell()
	{
		this.InitializeComponent();

		Splash.Source = _loadable;

		Loaded += OnLoaded;
	}

	private async void OnLoaded(object sender, RoutedEventArgs e)
	{
		await _loadable.Execute();
	}
}

public class MyLoadableSource : ILoadable
{

	public event EventHandler? IsExecutingChanged;

	private bool _isExecuting;
	public bool IsExecuting
	{
		get => _isExecuting;
		set
		{
			if (_isExecuting != value)
			{
				_isExecuting = value;
				IsExecutingChanged?.Invoke(this, new());
			}
		}
	}

	public async Task Execute()
	{
		try
		{
			IsExecuting = true;
			await Task.Delay(5000);
		}
		finally
		{
			IsExecuting = false;
		}
	}
}
