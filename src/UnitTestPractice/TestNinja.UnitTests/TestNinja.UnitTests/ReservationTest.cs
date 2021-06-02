using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTest
    {

        private Reservation _reservation;

        [TestInitialize]
        public void TestInitialize()
        {
            _reservation = new Reservation();
        }


        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_returnsTrue()
        {
            //Arrange
            //var reservation = new Reservation();

            //Act
            var result = _reservation.CanBeCancelledBy(new User() { IsAdmin = true });

            //Assert
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void CanBeCanceledBy_UserCreated_returnsTrue()
        {
            //Assign
            // var reservation = new Reservation();
            var user = new User() { IsAdmin = false };
            _reservation.MadeBy = user;

            //Act
            var result = _reservation.CanBeCancelledBy(user);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanNotBeCanceledBy_UserNotCreate_returnsFalse()
        {
            //Assign
            //  var reservation = new Reservation();
            var userCreatedReservation = new User() { IsAdmin = false };
            var userNotCreatedTheReservation = new User() { IsAdmin = false };
            _reservation.MadeBy = userCreatedReservation;

            //Act
            var result = _reservation.CanBeCancelledBy(userNotCreatedTheReservation);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CanNotBeCreatedBy_NullUser_returnFalse()
        {
            //Assign
            //var reservation = new Reservation();
            var userCreatedReservation = new User() { IsAdmin = false };

            _reservation.MadeBy = userCreatedReservation;

            User userToTest = null;

            //Act
            var result = _reservation.CanBeCancelledBy(userToTest);

            //Assert
            Assert.IsFalse(result);

        }
    }
}
