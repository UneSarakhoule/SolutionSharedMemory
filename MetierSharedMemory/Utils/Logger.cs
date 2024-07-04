using MetierSharedMemory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetierSharedMemory.Utils
{

	public class Logger
	{
        BdSharedMemoryContext db = new BdSharedMemoryContext();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="TitreErreur"></param>
        /// <param name="erreur"></param>
        /// 
        public void WriteDataError(String TitreErreur, String erreur)
        {
            try
            {
                Td_Erreur log = new Td_Erreur();
                log.DataErreur = DateTime.Now;
                log.DescriptionErreur = erreur.Length > 1000 ? erreur.Substring(erreur.Length - 1000) : erreur;
                log.TitreErreur = TitreErreur;
                db.td_Erreurs.Add(log);
                db.SaveChanges();
            }catch (Exception ex)
            {
                WriteLogSystem(ex.ToString(), "WriteDataError");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void WriteLogSystem(string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }

}