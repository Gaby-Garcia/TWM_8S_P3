using ISR.Practica3.Core.Entities;
using ISR.Practica3.Core.Managers.Interfaces;
using ISR.Practica3.Core.Services.Interfaces;

namespace ISR.Practica3.Core.Managers;

public class IsrManager : IIsrManager{

    private readonly IIsrService _service;

    public IsrManager(IIsrService service){
        _service = service;
    }

    public Isr GetIsr(Income income){
        return _service.ProcessIsr(income);
    }
}