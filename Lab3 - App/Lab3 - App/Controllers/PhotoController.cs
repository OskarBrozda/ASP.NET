﻿using Lab3___App.Models;using Microsoft.AspNetCore.Mvc;namespace Lab3___App.Controllers{    public class PhotoController : Controller    {                static readonly Dictionary<int, Photo> _photos = new Dictionary<int, Photo>();        public IActionResult Gallery()        {            return View(_photos);        }        [HttpGet] // wyświetla formularz        public IActionResult Create() => View();        [HttpPost] // pobiera dane z formularza        public IActionResult Create(Photo model)        {            if (ModelState.IsValid)            {                int id = _photos.Keys.Count != 0 ? _photos.Keys.Max() : 0;                model.Id = ++id;                _photos[id] =  model;                return RedirectToAction("Gallery");            }            return View();        }        [HttpGet]        public IActionResult Update(int id) => View(_photos[id]);        [HttpPost]        public IActionResult Update(Photo model)        {            if(ModelState.IsValid)            {                _photos[model.Id] = model;                return RedirectToAction("Gallery");            }            return View();        }        [HttpGet]        public IActionResult Details(int id) => View(_photos[id]);        [HttpGet]        public IActionResult Delete(int id) => View(_photos[id]);        [HttpPost]        public IActionResult DeleteConfirmed(int id)        {            _photos.Remove(id);            return RedirectToAction("Gallery");        }    }}