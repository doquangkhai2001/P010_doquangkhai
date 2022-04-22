namespace MvcMovie.Models;

public class ErrorViewModel
{
    [System.ComponentModel.Bindable(true)]
    public string? RequestId { get; set; }

[System.ComponentModel.Bindable(true)]
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
