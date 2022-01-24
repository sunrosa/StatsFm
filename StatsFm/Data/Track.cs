namespace StatsFm.Data
{
    public class Track
    {
        /// <summary>
        /// The name of the artist who created the track
        /// </summary>
        /// <value></value>
        public string ArtistName { get; set; }

        /// <summary>
        /// The name of the album in which the track lies
        /// </summary>
        /// <value></value>
        public string ReleaseName { get; set; }

        /// <summary>
        /// The name of the track
        /// </summary>
        /// <value></value>
        public string TrackName { get; set; }
        public MusicBrainzMetadata MusicBrainzMetadata { get; set; }
    }
}
