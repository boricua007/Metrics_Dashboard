﻿using DAL;
using DAL.Classes;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class Dashboard_BL
    {
        // DROPDOWN LIST LOAD
        public List<Client> GetClients( )
        {
            using ( var db = new DataConn_DB( ) )
            {
                return db.clients.ToList( );
            }
        }



        public void CreateClient( string firstName, string lastName, string email, string password )
        {
            var newClient = new Client( )
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password
            };
            using ( var db = new DataConn_DB() )
            {
                db.clients.Add( newClient );
                db.SaveChanges( );
            }
        }

        public void UpdateClient( int clientId, Client client )
        {
            using ( var db = new DataConn_DB() )
            {
                var currentClient = db.clients.Find( clientId );
                currentClient.FirstName = client.FirstName;
                currentClient.LastName = client.LastName;
                currentClient.Email = client.Email;

                db.SaveChanges( );
            }
        }

        public void DeleteClient( int clientId )
        {
            using ( var db = new DataConn_DB() )
            {
                var currentClient = db.clients.Find( clientId );
                db.clients.Remove( currentClient );

                db.SaveChanges( );
            }
        }

        public Client GetClient( int clientId )
        {
            using ( var db = new DataConn_DB( ) )
            {
                var currentClient = db.clients.Where( x => x.Id == clientId ).FirstOrDefault( );
                return currentClient;
            }
        }
    }
}
