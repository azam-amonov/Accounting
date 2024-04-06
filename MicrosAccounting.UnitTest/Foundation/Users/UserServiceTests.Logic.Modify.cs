using FluentAssertions;
using Force.DeepCloner;
using MicrosAccounting.Api.Models.Users;
using Moq;

namespace MicrosAccounting.UnitTest.Foundation.Users;

public partial class UserServiceTests
{
    [Fact]
    public async Task ShouldModifyUserAsync()
    {
        //given
        User randomUser = CreateRandomUser();
        User inputUser = randomUser;
        User persistedUser = inputUser;
        User updatedUser  = persistedUser;
        User expectedUser = updatedUser.DeepClone();
        Guid inputUserId = inputUser.Id;

        this.storageBrokerMock.Setup(broker =>
            broker.SelectUserByIdAsync(inputUserId))
                .ReturnsAsync(expectedUser);

        this.storageBrokerMock.Setup(broker => 
            broker.UpdateUserAsync(inputUser))
                .ReturnsAsync(updatedUser);
        
        //when
        User actualUser = 
            await this.userService.ModifyUserAsync(inputUser);
        
        //then
        actualUser.Should().BeEquivalentTo(expectedUser);
        
        this.storageBrokerMock.Verify(broker => 
            broker.SelectUserByIdAsync(inputUser.Id), Times.Once);

        this.storageBrokerMock.Verify(broker =>
            broker.UpdateUserAsync(inputUser), Times.Once);
        
        this.storageBrokerMock.VerifyNoOtherCalls();
    }
}