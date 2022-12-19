using WebApplication2.Application.Interface;
using WebApplication2.Application.Service;

namespace TestProject1
{
    public class UnitTest1: IClassFixture<TaskToBeDone>
    {
        private ITaskToBeDone _taskToBeDone = new TaskToBeDone();
        [Fact]
        public void Equilateral_Triangle()
        {
            var expectedString = "Equilateral";
            var result = _taskToBeDone.DetermineTriangale(3, 3, 3);
            Assert.Equal(expectedString, result);
        }

        [Fact]
        public void Isoceles_Triangle()
        {
            var expectedString = "Isosceles";
            var result = _taskToBeDone.DetermineTriangale(1, 2, 2);
            Assert.Equal(expectedString, result);
        }

        [Fact]
        public void Scalene_Triangle()
        {
            var expectedString = "Scalene";
            var result = _taskToBeDone.DetermineTriangale(1, 2, 3);
            Assert.Equal(expectedString, result);
        }
    }
}