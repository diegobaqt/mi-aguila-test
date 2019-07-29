using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyEagleTest.Services.Interfaces;
using MyEagleTest.Extensions;
using MyEagleTest.Models;
using MyEagleTest.ViewModels.Trip;
using MyEagleTest.ViewModels.Shared;

namespace MyEagleTest.Controllers
{
    [Route("[controller]/[action]")]
    public class TripController : Controller
    {
        private readonly ITripService _tripService;
        private readonly ILogger _logger;

        #region Constructor
        public TripController(ITripService tripService, ILogger<TripController> logger)
        {
            _tripService = tripService;
            _logger = logger;
        }
        #endregion

        #region Get

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var travels = _tripService.FindAll();
                return Ok(travels);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.HResult, ex.InnerException == null ? ex.Message : ex.InnerException.Message);
                return BadRequest(ServiceResponseExtension.GenericResponse);
            }
        }

        [HttpGet]
        public IActionResult GetQuantityRecords([FromBody] ReportPagedVm reportPagedVm)
        {
            try
            {
                var quantity = _tripService.FindQuantityRecords(reportPagedVm).Quantity;
                return Ok(quantity);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.HResult, ex.InnerException == null ? ex.Message : ex.InnerException.Message);
                return BadRequest(ServiceResponseExtension.GenericResponse);
            }
        }

        [HttpGet]
        public IActionResult GetAllFilteredAndPaged([FromBody] ReportPagedVm reportPagedVm)
        {
            try
            {
                var travels = _tripService.FilteredAndPaged(reportPagedVm);
                return Ok(travels);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.HResult, ex.InnerException == null ? ex.Message : ex.InnerException.Message);
                return BadRequest(ServiceResponseExtension.GenericResponse);
            }
        }

        [HttpGet]
        public IActionResult GetById([FromBody] TripIdViewModel tripIdViewModel)
        {
            try
            {
                var travels = _tripService.FindById(tripIdViewModel.Id);
                return Ok(travels);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.HResult, ex.InnerException == null ? ex.Message : ex.InnerException.Message);
                return BadRequest(ServiceResponseExtension.GenericResponse);
            }
        }

        #endregion

        #region Post

        [HttpPost]
        public IActionResult Add([FromBody] Trip trip)
        {
            try
            {
                var createdTravel = _tripService.Add(trip);
                return Ok(ServiceResponseExtension.TripCreatedSuccessfully);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.HResult, ex.InnerException == null ? ex.Message : ex.InnerException.Message);
                return BadRequest(ServiceResponseExtension.GenericResponse);
            }
        }

        [HttpPost]
        public IActionResult AddAll([FromBody] TripsToAddViewModel tripsToAddViewModel)
        {
            try
            {
                _tripService.AddAll(tripsToAddViewModel.Trips);
                return Ok(ServiceResponseExtension.TripsCreatedSuccessfully);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.HResult, ex.InnerException == null ? ex.Message : ex.InnerException.Message);
                return BadRequest(ServiceResponseExtension.GenericResponse);
            }
        }

        #endregion

        #region Put

        [HttpPut]
        public IActionResult Update([FromBody] Trip trip)
        {
            try
            {
                _tripService.Update(trip.Id, trip);
                return Ok(ServiceResponseExtension.TripUpdatedSuccessfully);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.HResult, ex.InnerException == null ? ex.Message : ex.InnerException.Message);
                return BadRequest(ServiceResponseExtension.GenericResponse);
            }
        }

        #endregion

        #region Delete

        [HttpDelete]
        public IActionResult Delete([FromBody] Trip trip)
        {
            try
            {
                _tripService.Remove(trip);
                return Ok(ServiceResponseExtension.TripRemovedSuccessfully);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.HResult, ex.InnerException == null ? ex.Message : ex.InnerException.Message);
                return BadRequest(ServiceResponseExtension.GenericResponse);
            }
        }

        [HttpDelete]
        public IActionResult DeleteById([FromBody] TripIdViewModel tripIdViewModel)
        {
            try
            {
                _tripService.RemoveById(tripIdViewModel.Id);
                return Ok(ServiceResponseExtension.TripRemovedSuccessfully);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.HResult, ex.InnerException == null ? ex.Message : ex.InnerException.Message);
                return BadRequest(ServiceResponseExtension.GenericResponse);
            }
        }

        #endregion

    }
}