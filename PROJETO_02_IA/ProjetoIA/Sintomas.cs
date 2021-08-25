using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoIA
{
    class Sintomas
    {

        public double diagnostico = 0;

        public int Febre(int febre)
        {
            if (febre == 1)
                diagnostico = diagnostico + 0.5 ;

            return 0;
        }

        public int Tosse_seca(int tosse_seca)
        {
            if (tosse_seca == 1)
                diagnostico = diagnostico + 0.5;

            return 0;
        }

        public int Cansaco(int cansaco)
        {

            if (cansaco == 1)
                diagnostico = diagnostico + 0.5;

            return 0;
        }

        public int Dores(int dores)
        {

            if (dores == 1)
                diagnostico = diagnostico + 0.2;

            return 0;
        }

        public int Dor_de_garganta(int dor_de_garganta)
        {

            if (dor_de_garganta == 1)
                diagnostico = diagnostico + 0.2;

            return 0;

        }

        public int Diarreia(int diarreia)
        {

            if (diarreia == 1)
                diagnostico = diagnostico + 0.2;

            return 0;
        }

        public int Conjutivite(int conjuntivite)
        {

            if (conjuntivite == 1)
                diagnostico = diagnostico + 0.2;

            return 0;
        }

        public int Dor_de_cabeca(int dor_de_cabeca)
        {
            if (dor_de_cabeca == 1)
                diagnostico = diagnostico + 0.2;

            return 0;
        }

        public int Perda_paladar_respiracao(int perda_palada_olfato)
        {

            if (perda_palada_olfato == 1)
                diagnostico = diagnostico + 0.2;

            return 0;
        }

        public int Dificuldade_respirar(int dificuldade_respirar)
        {

            if (dificuldade_respirar == 1)
                diagnostico = diagnostico + 1;


            return 0;

        }

        public int Dor_no_peito(int dor_no_peito)
        {

            if (dor_no_peito == 1)
                diagnostico = diagnostico + 1;

            return 0;
        }

        public int Perda_fala(int perda_fala)
        {

            if (perda_fala == 1)
                diagnostico = diagnostico + 1;

            return 0;

        }

        public int Diabetes(int comorbidade)
        {

            if (comorbidade == 1)
                diagnostico = diagnostico + 0.1;

            return 0;
        }

        public int Hipertensao(int hipertensao)
        {
            if(hipertensao == 1)
                diagnostico = diagnostico + 0.1;

            return 0;
        }

        public string Diagnostico()
        {
            string teste = "";
            if (diagnostico <= 1)
            {
               
                teste = "Saudável, não acumulou evidências suficientes para COVID!!";
                diagnostico = 0;
            }
            if(diagnostico > 1 && diagnostico <= 2)
            {      
                teste = "Suspeito para COVID, procure um posto de saude!!";
                diagnostico = 0;
            }

            if(diagnostico > 2)
            {
                teste = "Chance muito alta para COVID, procure um hospital urgentemente!!";
                diagnostico = 0;
            }

            
            return teste;
            
        }

      
    }
}
