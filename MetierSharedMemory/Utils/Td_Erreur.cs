using System;

namespace MetierSharedMemory.Model
{
    public class Td_Erreur
    {
        public int Id { get; set; }
        public DateTime DataErreur { get; internal set; }
        public string DescriptionErreur { get; internal set; }
        public string TitreErreur { get; internal set; }
    }
}