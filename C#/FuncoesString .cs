using System;

namespace Helper {

    public static class FuncoesString {

        public static string CalculaDVAR(string numeroAR)
        {
            int digPos1;
            int digPos2;
            int digPos3;
            int digPos4;
            int digPos5;
            int digPos6;
            int digPos7;
            int digPos8;
            int dv;

            //Resgata os dígitos individuais do número do AR
            int.TryParse(numeroAR.Substring(0, 1), out digPos1);
            int.TryParse(numeroAR.Substring(1, 1), out digPos2);
            int.TryParse(numeroAR.Substring(2, 1), out digPos3);
            int.TryParse(numeroAR.Substring(3, 1), out digPos4);
            int.TryParse(numeroAR.Substring(4, 1), out digPos5);
            int.TryParse(numeroAR.Substring(5, 1), out digPos6);
            int.TryParse(numeroAR.Substring(6, 1), out digPos7);
            int.TryParse(numeroAR.Substring(7, 1), out digPos8);

            //Aplica os fatores de ponderação sobre os números de base, utilizando os seguintes algarismos: 8, 6, 4, 2, 3, 5, 9 e 7
            //Efetua a soma de todos os produtos
            dv = (digPos1 * 8) + (digPos2 * 6) + (digPos3 * 4) + (digPos4 * 2) + (digPos5 * 3) + (digPos6 * 5) + (digPos7 * 9) + (digPos8 * 7);

            //Divide a soma por 11 e retorna o resto
            dv = dv % 11;

            //Analisa o resto retornado para definir qual é o DV do código
            if (dv == 0) dv = 5; //Se o resto for 0, o DV é 5
            if (dv == 1) dv = 0; //Se o resto for 1, o DV é 0
            if (dv != 0 & dv != 1) dv = 11 - dv; //Se o resto não for 1 ou 0, ele será o resultado da subtração do número 11 pelo resto

            return dv.ToString();
        }
    }
}
