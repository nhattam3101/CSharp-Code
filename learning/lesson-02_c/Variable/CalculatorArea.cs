namespace Variable;

public class CalculatorArea
{
    public static double CalculateSquareArea(int edge)
    {
        return edge * edge;
    }

    public static double CalculateRectangleArea(int rectangleWidth, int rectangleLength)
    {
        return rectangleWidth * rectangleLength;
    }
    
    [ApiController]
    [Route("api/[controller]")]
    public class CourtsController : ControllerBase
    {
        private readonly ICourtService _courtService;

        public CourtsController(ICourtService courtService)
        {
            _courtService = courtService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var court = await _courtService.GetByIdAsync(id);

            if (court == null)
                return NotFound();

            return Ok(court);
        }
    }
    
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public string RefreshToken { get; set; }
    }
    
    public class UserResponse
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
    }
    public static double CalculateCircleArea(int circleRadius)
    {
        const double Pi = 3.14;
        return Pi * circleRadius * circleRadius;
    }
    
    public interface ICourtService
    {
        Task<Court?> GetByIdAsync(Guid id);
    }
    
    
    public class CourtService : ICourtService
    {
        public async Task<Court?> GetByIdAsync(Guid id)
        {
            return await _dbContext.Courts
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}