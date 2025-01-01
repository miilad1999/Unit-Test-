using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTesr
{
    [TestFixture]
    public class ResrvationtTestd
    {
        [Test]
        public void CanBeCancelledBy_UserAdmin_ReturnTrue()
        {
            //Arrnge
            var reservation = new Reservation();
            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            //Assert

            Assert.IsTrue(result);

        }
        [Test]
        public void CanBeCancelledBy_SameUsercancellingTheReservation_ReturnTrue()
        {
            //Arrnge
            var user = new User();
            var reservation = new Reservation { MadeBy = user };
            //Act
            var result = reservation.CanBeCancelledBy(user);
            //Assert

            Assert.IsTrue(result);

        }
        [Test]
        public void CanBeCancelledBy_DifferentUser_ReturnsFalse()
        {
            // Arrange
            var userWhoMadeReservation = new User();
            var differentUser = new User();
            var reservation = new Reservation { MadeBy = userWhoMadeReservation };

            // Act
            var result = reservation.CanBeCancelledBy(differentUser);

            // Assert
            Assert.IsFalse(result);
        }

    }
}
