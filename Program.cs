﻿using System;
using System.IO;
using NLog.Web;
using System.Collections.Generic;
namespace TicketingOOP
{
    class Program
    {
        //Create static logger to go across all files
        private static NLog.Logger logger = NLogBuilder.ConfigureNLog(Directory.GetCurrentDirectory() + "\\nlog.config").GetCurrentClassLogger();

        //Method to view tickets
        void viewTickets(TicketFile ticketFile){
            //for each ticket in viewTicket, 
            //Print it to the console
        }

        //Method to add tickets
        void addTicket(Ticket ticket){

        }
        static void Main(string[] args)
        {
            //Create file path
            string file = Directory.GetCurrentDirectory() + "\\Tickets.csv";
            //Create TicketFile
            TicketFile tickets = new TicketFile(file);

            /*
            TO DO:
            - Allow User To 
                - View Tickets
                - Add Tickets
                - Erase Tickets
            - USE METHODS
            - Create Ticket Class
            - Create TicketFile Class

            Plan:
            - Create TicketFile object, load in tickets
            - Do-While Loop of:
                - Give user menu
                    - Switch that goes to appropriate function
                        - 1.) View Tickets
                            - Print out each line (including header) 
                        - 2.) Add Ticket
                            - Gen' New ID
                            - Ask User For:
                                - Summary
                                - Status
                                - Priority
                                - Submitter
                                - Assigner
                                - Watching
                            - If any section is blank, put in "N/A" instead
                            - Create new Ticket object
                            - Add ticket to list of tickets and ticket file
                        - 3.) Erase Tickets
                            - Make sure user's sure
                                - If they aren't, go back to menu
                                - If they are, clear file
            */
        }
    }
}
