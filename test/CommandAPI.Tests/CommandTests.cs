using System;
using CommandAPI.Models;
using Xunit;

namespace CommandAPI.Tests{
    public class CommandTests: IDisposable{
        Command testCommand;
        public CommandTests()
        {
            testCommand = new Command
            {
                HowTo = "Do something",
                Platform = "some platform",
                CommandLine = "some commandline"
            };
        }
        public void Dispose()
        {
            testCommand = null;
        }
        [Fact]
        public void CanChangeHowTo()
        {
            //Arrange
            //Act
            testCommand.HowTo = "Execute Unit Tests";
            //Assert
            Assert.Equal("Execute Unit Tests", testCommand.HowTo);
        }
        [Fact]
        public void CanChangePlatform()
        {
            //Act
            testCommand.Platform = "xUnit test";
            //Assert
            Assert.Equal("xUnit test", testCommand.Platform);
        }

        [Fact]
        public void CanChangeCommandLine()
        {
            //Act
            testCommand.CommandLine = "dotnet test";
            //Assert
            Assert.Equal("dotnet test", testCommand.CommandLine);
        }

        
    }
}