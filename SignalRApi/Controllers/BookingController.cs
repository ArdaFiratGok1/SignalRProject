using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.BookingDto;
using SignalR.EntityLayer.Entitites;


namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly IMapper _mapper;

        public BookingController(IBookingService bookingService, IMapper mapper)
        {
            _bookingService = bookingService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ListBooking()
        {
            var value = _mapper.Map<List<ResultBookingDto>>(_bookingService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]
        //Burada kursta, AboutController'da olduğu gibi manuel olarak atama yapılıyor propertyleri ama bunun yerine ben, AutoMapper'in asıl amacını yani otomatik eşleştirmeyi yapıyorum. Nasıl yapıldığı fonksiyonun içinde görülüyor.
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            var bookingEntity = _mapper.Map<Booking>(createBookingDto);
            //Burada yukarıda bahsettiğim olay CreateBookingDto'da id yok mesela ama bir sıkıntı çıkmıyor.

            _bookingService.TAdd(bookingEntity);
            return Ok("successfully added");
        }

        [HttpDelete]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.TGetById(id);
            _bookingService.TDelete(value);
            return Ok("successfully deleted");

        }

        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            var bookingEntity = _mapper.Map<Booking>(updateBookingDto);
            _bookingService.TUpdate(bookingEntity);
            return Ok("successfully updated");
        }

        [HttpGet("GetBooking")]

        public IActionResult GetBooking(int id)
        {
            var value = _mapper.Map<GetBookingDto>(_bookingService.TGetById(id));
            return Ok(value);
        }

    }
}
