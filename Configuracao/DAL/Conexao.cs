﻿using System.Reflection.Metadata;

namespace DAL
{
    public static class Conexao
    {
        public static string StringDeConexao
        {
            get
            {
                return @"User ID=SA; Initial Catalog=Gestao;Data Source=.\SQLEXPRESS2019;Password=Senailab02";
            }
        }
    }
}
