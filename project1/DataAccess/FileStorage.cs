﻿using System.Text.Json;
using Models;
namespace DataAccess;
// In this project, all we'll do is getting and persisting data
// Code in this project will not be doing any of the following
// - Input Validation
// - Console I/O
// - Any complex application logic

    public class FileStorage
    {
        private const string _filePath = "../DataAccess/TicketLogs.json";
        public FileStorage() {
            // I want to write my data in JSON format
            // The process of converting data to string/bit for transportation or persistence is called Serialization
            // The process of taking the string/bit/etc and translating back into Objects is called Deserialization

            // When we initialize this class, let's make sure the file we want to modify exists, and if not, let's create it.
            // File is an example of unmanaged resource, aka CLR (common language runtime does not garbage collect it for you. You have to manually close/dispose it)
            bool fileExists = File.Exists(_filePath);

            if(!fileExists) {
                var fs = File.Create(_filePath);
                fs.Close();
            }
        }

        public List<TicketSession> GetAllTicket() {
            // Open the file, read the content, close the file
            string fileContent = File.ReadAllText(_filePath);

            // The read string, and deserialize it back to List of workout sessions
            return JsonSerializer.Deserialize<List<TicketSession>>(fileContent);
        }

        public void CreateNewSession(TicketSession sessionToCreate) {
            // Reading from an existing file and deserializing it as list of ticket
            List<TicketSession> sessions = GetAllTicket();
            // Adding new ticket session
            sessions.Add(sessionToCreate);

            // Serializing the list as string and writing it back to the file
            string content = JsonSerializer.Serialize(sessions);
            File.WriteAllText(_filePath, content);
        }
    }
