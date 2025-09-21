using ShattuckProject2.Components.Pages;

namespace ShattuckProject2.Services
{
    /// <summary>
    /// Adds/Deletes a note
    /// </summary>
    public class NotesService
    {
        public List<Note> Notes { get; private set; } = new List<Note>(); // List of Notes

        /// <summary>
        /// Adds a note
        /// </summary>
        /// <param name="note">The note a user writes</param>
        public void AddNote(Note note)
        {
            Notes.Add(note);
        }

        /// <summary>
        /// Deletes a note
        /// </summary>
        /// <param name="note">The note a user writes</param>
        public void DeleteNote(Note note)
        {
            Notes.Remove(note);
        }
    }

    /// <summary>
    /// Holds onto a note's content and references
    /// </summary>
    public class Note
    {
        public string Content { get; set; }
        public List<string> References { get; set; } = new List<string>();
    }
}
