using System;
using System.ComponentModel;

namespace CocoaRhino_CS
{
  /// <summary>
  /// Super basic implementation of an INotifyPropertyChanged ViewModel base class.
  /// </summary>
  public abstract class ViewModelBase : INotifyPropertyChanged
  {
    /// <summary>
    /// Raised when a property on this object has a new value
    /// </summary>
    public event PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    /// Raises the property changed event.
    /// </summary>
    /// <param name='propertyName'>
    /// Property name.
    /// </param>
    protected virtual void OnPropertyChanged(string propertyName)
    {
      if( PropertyChanged!=null )
      {
        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
      }
    }
  }
}

