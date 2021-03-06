﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsAPP.Repository.Lib;
using SportsAPP.Models;

namespace SportsAPP.Repository.Data
{
    public class StateDetailsData
    {
        MyDataSourceFactory obj = new MyDataSourceFactory();

        public List<dynamic> AddStateDetails(StateDetailsDTO stateDetailsDTO)
        {
            string insertProcedure = "[CRUD_StateMaster]";

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();
            input_parameters.Add("@pkey_state_id", 1 + " #bigint# " + stateDetailsDTO.pkey_state_id);
            input_parameters.Add("@state_name", 1 + " #varchar# " + stateDetailsDTO.state_name);

            input_parameters.Add("@UserID ", 1 + " #bigint# " + stateDetailsDTO.UserID);
            input_parameters.Add("@is_delete ", 1 + " #int# " + stateDetailsDTO.is_delete);
            input_parameters.Add("@Type", 1 + " #int# " + stateDetailsDTO.Type);
            input_parameters.Add("@pkey_state_idOut", 2 + " #int# " + null);
            input_parameters.Add("@ReturnValue", 2 + " #int# " + null);

            return obj.SqlCRUD(insertProcedure, input_parameters);


        }
    }
}