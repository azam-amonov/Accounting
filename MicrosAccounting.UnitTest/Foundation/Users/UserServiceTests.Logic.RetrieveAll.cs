using FluentAssertions;
using MicrosAccounting.Api.Models.Users;
using Moq;
using Xunit;

namespace MicrosAccounting.UnitTest.Foundation.Users;

public partial class UserServiceTests
{
    [Fact]
    public void ShouldRetrieveUsers()
    {
        //given
        IQueryable<User> randomUsers = CreateRandomUsers();
        IQueryable<User> storageUsers = randomUsers;
        IQueryable<User> expectedUsers = storageUsers;
        
        this.storageBrokerMock.Setup(broker =>
            broker.SelectAllUsers()).Returns(storageUsers);

        //when
        IQueryable<User> actualUsers =
            this.userService.RetrieveAllUsers();
        
        //then
        actualUsers.Should().BeEquivalentTo(expectedUsers);
        
        this.storageBrokerMock.Verify(broker =>
            broker.SelectAllUsers(), Times.Once);
        
        this.storageBrokerMock.VerifyNoOtherCalls();
    }
}