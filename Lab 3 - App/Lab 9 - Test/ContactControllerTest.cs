using Lab_3___App.Controllers;
using Lab_3___App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_9___Test;

public class ContactControllerTest
{
    private ContactController _controller;
    private IContactService _service;
    private CurrentDateTimeProvider _timeProvider;

    public ContactControllerTest()
    {
        _service = new MemoryContactService();
        _timeProvider = new CurrentDateTimeProvider();
        _service.Add(new Contact() { Id = 1 });
        _service.Add(new Contact() { Id = 2 });
        _controller = new ContactController(_service, _timeProvider);
    }

    [Fact]
    public void IndexTest()
    {
        var result = _controller.Index();
        Assert.IsType<ViewResult>(result);
        var view = result as ViewResult;
        var model = view.Model as List<Contact>;
        Assert.Equal(2, model.Count);
    }
}