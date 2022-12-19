using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Application.Interface;
using WebApplication2.Model;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JacController : ControllerBase
    {
        private ITaskToBeDone _taskToBeDone;
        public JacController(ITaskToBeDone taskToBeDone)
        {
            _taskToBeDone = taskToBeDone;
        }

        /// <summary>
        /// Determine the shape of the triangle.
        /// </summary>
        /// <param name="requestTriangle">Each side of the triangle.</param>
        /// <returns>Shape of the triangle.</returns>
        [Route("[action]")]
        [HttpPost]
        public string Triangle(RequestTriangle requestTriangle)
        {
            return _taskToBeDone.DetermineTriangale(requestTriangle.side1, requestTriangle.side2, requestTriangle.side3);
        }

        /// <summary>
        /// Fibonancci numbers.
        /// </summary>
        /// <param name="requestFibonacci">The maximum value of fibonancci.</param>
        /// <returns>Value of fibonacci numbers.</returns>
        [Route("[action]")]
        [HttpPost]
        public string Fibonacci(RequestFibonacci requestFibonacci)
        {
            return _taskToBeDone.Fibonacci(requestFibonacci.element);
        }

        /// <summary>
        /// Reversing word.
        /// </summary>
        /// <param name="requestWord">Word to be reverse.</param>
        /// <returns>Reversed word.</returns>
        [Route("[action]")]
        [HttpPost]
        public string WordReverse(RequestWord requestWord)
        {
            return _taskToBeDone.WordReverse(requestWord.word);
        }

        /// <summary>
        /// Hashing word.
        /// </summary>
        /// <param name="requestWord">Word to be hashed.</param>
        /// <returns>Hashed word and akgorithm used.</returns>
        [Route("[action]")]
        [HttpPost]
        public ResponseHashed WordHashed(RequestWord requestWord)
        {
            ResponseHashed responseHashed = new ResponseHashed();
            responseHashed.algorithm = "SHA512";
            responseHashed.value = _taskToBeDone.WordHash(requestWord.word);

            return responseHashed;
        }
    }
}
