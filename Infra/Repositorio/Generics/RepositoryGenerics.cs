using Domain.Interfaces.Genereics;
using Infra.Configuracao;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace Infra.Repositorio.Generics;

public class RepositoryGenerics<T> : InterfaceGeneric<T>, IDisposable where T : class
{
    private readonly DbContextOptions<ContextBase> _OptionsBuilder;

    //public RepositoryGenerics(DbContextOptions<ContextBase> optionsBuilder)
    //{
    //    _OptionsBuilder = optionsBuilder;
    //}

    public RepositoryGenerics()
    {
        _OptionsBuilder = new DbContextOptions<ContextBase>();
    }

    public async Task Add(T objeto)
    {
        using (var data = new ContextBase(_OptionsBuilder))
        {
            await data.Set<T>().AddAsync(objeto);
            await data.SaveChangesAsync();
        }
    }

    public async Task Delete(T objeto)
    {
        using (var data = new ContextBase(_OptionsBuilder))
        {
             data.Set<T>().Remove(objeto);
            await data.SaveChangesAsync();
        }
    }

    public async Task<T> GetEntityById(int Id)
    {

        using (var data = new ContextBase(_OptionsBuilder))
        {
            return await data.Set<T>().FindAsync(Id);
        }
    }

    public async Task<List<T>> List()
    {
        using (var data = new ContextBase(_OptionsBuilder))
        {
            return await data.Set<T>().ToListAsync();
        }

    }

    public async Task Update(T objeto)
    {
        using (var data = new ContextBase(_OptionsBuilder))
        {
             data.Set<T>().Update(objeto);
            await data.SaveChangesAsync();
        }
    }




    //Dispose
    bool disposed = false;
    SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
    public void Dispose()
    {
        // Dispose of unmanaged resources.
        Dispose(true);
        // Suppress finalization.
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposed)
        {
            return;
        }

        if (disposing)
        {
            handle.Dispose();
            // Dispose managed state (managed objects).
            // ...
        }

        // Free unmanaged resources.
        // ...

        disposed = true;
    }

}
