using System.Collections.Generic;
using System.Threading.Tasks;
using api_comil.Models;
using Microsoft.AspNetCore.Mvc;

namespace api_comil.Interfaces
{
    public interface IEvento
    {
        Task<ActionResult<Evento>> Post(Evento evento);
        Task<ActionResult<Evento>> Update();//validações de edição
        Task<ActionResult> Delete();
        Task<ActionResult<List<Evento>>> Get();
        Task<Evento> Get(int id);
        Task<ActionResult<List<Evento>>> ThougthworksEvents(); //eventos tw
        Task<ActionResult<List<Evento>>> PendingUser(); //eventos pendentes do usuario
        Task<ActionResult<List<Evento>>> ApprovedUser(); //eventos aprovados do usuario 
        Task<ActionResult<List<Evento>>> RealizeUser(); //eventos em analise do usuario 
        Task<ActionResult<List<Evento>>> PendingWeek(); //eventos pendentes para o adm aceitar ou recusar
        Task<ActionResult<List<Evento>>> PendingMounth(); //eventos pendentes para o adm aceitar ou recusar
        Task<Evento> Reject(Evento evento, int responsavel); //eventos pendentes para o adm aceitar ou recusar
        Task<Evento> Accept(Evento evento, int responsavel); //eventos pendentes para o adm aceitar ou recusar
        Task<ActionResult<List<Evento>>> MyEventsReject(); // eventos que o adm recusou
        Task<ActionResult<List<Evento>>> MyEventsAccept(); // eventos que o adm aceitou
        Task<ActionResult<List<Evento>>> Search(string filtro); // pesquisa de eventos, a partir do titulo, categoria, data 
        Task<ActionResult<List<Evento>>> Week(); //filtro por semana
        Task<ActionResult<List<Evento>>> Mounth(); //filtro por mes
        Task<ActionResult<List<Evento>>> EventByCategory(string cat);

    }
}