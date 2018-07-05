using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace Wrox.ProCSharp.DataServices
{
  public partial class WebRequestClientWindow : Window, INotifyPropertyChanged
  {
    const string defaultRequest = "http://localhost:9000/Samples/Menus";
    public WebRequestClientWindow()
    {
      InitializeComponent();
      UrlRequest = defaultRequest;
      JsonRequest = false;
      this.DataContext = this;
    }

    private async void OnRequest(object sender, RoutedEventArgs e)
    {
      Cursor oldCursor = this.Cursor;
      try
      {
        Result = string.Empty;
        this.Cursor = Cursors.Wait;

        using (var client = new HttpClient())
        {
          if (JsonRequest == true)
          {
            client.DefaultRequestHeaders.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
          }

            using (HttpResponseMessage response = await client.GetAsync(UrlRequest))
            {
              Result = await response.Content.ReadAsStringAsync();
            }

        }
      }
      catch (HttpRequestException ex)
      {
        Result = ex.Message;
      }
      catch (UriFormatException ex)
      {
        Result = ex.Message;
      }
      finally
      {
        this.Cursor = oldCursor;
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private string result;
    public string Result
    {
      get { return result; }
      set {
        SetProperty(ref result, value);
      }
    }
 
    private string urlRequest;
    public string UrlRequest
    {
      get
      {
        return urlRequest;
      }
      set
      {
        SetProperty(ref urlRequest, value);
      }
    }

     private bool? jsonRequest;
    public bool? JsonRequest
    {
      get
      {
        return jsonRequest;
      }
      set
      {
        SetProperty(ref jsonRequest, value);
      }
    }

    private void OnPropertyChanged(string propertyName)
    {
      var handler = PropertyChanged;
      if (handler != null)
      {
        handler(this, new PropertyChangedEventArgs(propertyName));
      }
    }

    private void SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
    {
      if (!EqualityComparer<T>.Default.Equals(field, value))
      {
        field = value;
        OnPropertyChanged(propertyName);
      }
    }

  }
}
