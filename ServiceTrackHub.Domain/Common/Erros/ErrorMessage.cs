﻿namespace ServiceTrackHub.Domain.Common.Erros
{
    public sealed class ErrorMessage
    {
        #region User messages
        public static readonly string UserNotFound = "O Usuário com  Id {0} não foi encontrado";
        public static readonly string UserEmailAlreadyExists = "O email {0} já existe. Tente usar outro.";
        public static readonly string UserInvalid = "Usuário inválido";

        #endregion

        #region Task messages
        public static readonly string TaskNotFound = "A tarefa com o id {0} não foi encontrada";
        public static readonly string TaskInvalid = "Tarefa inválida";
        public static readonly string TaskNameAlreadyExists = "Já existe uma tarefa com o nome {}." +
            " Por favor, tente com outro nome";
        #endregion

        #region Task Type messages
        public static readonly string TaskTypeNotFound = "O tipo de tarefa com id {0} não foi encontrado";
        public static readonly string TaskTypeInvalid= "Tipo de tarefa inválido";
        #endregion


    }
}
