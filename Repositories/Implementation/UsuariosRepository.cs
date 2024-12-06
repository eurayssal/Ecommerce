using Ecommerce.Configurations;
using Ecommerce.Models;
using Ecommerce.Repositories.Interface;
using MongoDB.Driver;

namespace Ecommerce.Repositories.Implementation;

public class UsuariosRepository : IUsuariosRepository
{
    private readonly IMongoCollection<Usuario> _usuarios;

    public UsuariosRepository(IDatabaseConfig databaseConfig)
    {
        var client = new MongoClient(databaseConfig.ConnectionString);
        var database = client.GetDatabase(databaseConfig.DatabaseName);

        _usuarios = database.GetCollection<Usuario>("usuarios");
    }

    public void CadastroUsuario(Usuario usuario) { 
        _usuarios.InsertOne(usuario);
    }
}
