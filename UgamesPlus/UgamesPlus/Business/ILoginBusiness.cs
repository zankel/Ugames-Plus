﻿using RestWithASPNETUdemy.Data.VO;

namespace RestWithASPNETUdemy.Business
{
    public interface ILoginBusiness
    {
        TokenVO ValidateCredentials(UsuarioVO usuario);

        TokenVO ValidateCredentials(TokenVO token);

        bool RevokeToken(string userName);
    }
}