using System.Collections;
using System.Collections.Generic;
using MyProject;
using Xunit;
using Xunit.Abstractions;

namespace MyProjectTest
{
    public class UnitTest2
    {
        private readonly ITestOutputHelper _output;

        public UnitTest2(ITestOutputHelper output)
        {
            _output = output;
        }

        // Atende a maioria dos casos ----------------------------------

        [Theory(DisplayName = "User fields are filled")]
        [MemberData(nameof(UserList))]
        public void UserFieldsHasContent(Usuario usuario)
        {
            Assert.NotEmpty(usuario.Username);
            Assert.NotEmpty(usuario.Email);
            Assert.IsType<Usuario>(usuario);
        }

        public static IEnumerable<object[]> UserList => new[]
        {
            new [] { new Usuario { Id = 1, Username = "admin", Email = "admin@exemplo.com" }},
            new [] { new Usuario { Id = 2, Username = "usuario1", Email = "usuario1@exemplo.com" }},
            new [] { new Usuario { Id = 3, Username = "usuario2", Email = "usuario2@exemplo.com" }},
            new [] { new Usuario { Id = 4, Username = "usuario3", Email = "usuario3@exemplo.com" }},
        };

        // Usado em casos mais específicos --------------------------------

        [Theory(DisplayName = "User fields are filled from class")]
        [ClassData(typeof(UserListData))]
        public void UserFieldsHasContentClass(Usuario usuario)
        {
            Assert.NotEmpty(usuario.Username);
            Assert.NotEmpty(usuario.Email);
            Assert.IsType<Usuario>(usuario);
        }

        public class UserListData : IEnumerable<object[]>
        {
            private readonly List<object[]> _data = new List<object[]>
            {
                new [] { new Usuario { Id = 1, Username = "admin", Email = "admin@exemplo.com" }},
                new [] { new Usuario { Id = 2, Username = "usuario1", Email = "usuario1@exemplo.com" }},
                new [] { new Usuario { Id = 3, Username = "usuario2", Email = "usuario2@exemplo.com" }},
                new [] { new Usuario { Id = 4, Username = "usuario3", Email = "usuario3@exemplo.com" }},
            };

            public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}