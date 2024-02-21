using ISR.Practica3.Core.Entities;

namespace ISR.Practica3.Core.Services.Interfaces;

public interface IIsrService{
    Isr ProcessIsr (Income income);
    
}