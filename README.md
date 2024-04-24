# ShowStream
Explore a vast library of movies and TV series with ShowStream. Enjoy HD streaming, personalized profiles, offline viewing, and smart recommendations. Dive into endless entertainment!
![showStream Logo](https://github.com/madadiuk/ShowStream/assets/24778272/a44756b8-331d-4a28-a643-c02e6ef6b327)


#Database ERD Diagram:
![tblUsers (9)](https://github.com/madadiuk/ShowStream/assets/24778272/1b9e590f-df72-4acd-b2cb-bd2225a112a2)

tblUserProfiles
This table holds additional personal information about users. Each record links to a tblUsers record and includes the user's first name, last name, and date of birth.

ProfileID: A unique identifier for each user profile.
UserID: The ID of the user this profile belongs to.
FirstName: The user's first name.
LastName: The user's last name.
DateOfBirth: The user's date of birth.
tblUsers
This table stores the essential information of all users, including their credentials and roles within the platform.

UserID: A unique identifier for each user.
Username: The chosen username for the user, which must be unique.
Email: The user's email address, which must be unique.
Password: The user's password, stored in a hashed format for security.
Role: The user's role, which could be a regular user or an admin, controlling access to different parts of the system.
tblTransactions
This table records transactions made by users, which could involve purchasing subscriptions or content.

TransactionID: A unique identifier for each transaction.
UserID: The ID of the user who made the transaction.
Amount: The financial amount of the transaction.
TransactionDate: The date and time when the transaction occurred.
PaymentMethod: The method used for the transaction (e.g., credit card, PayPal).
Status: The current status of the transaction (e.g., completed, pending).
tblDownloads
This table tracks the downloads initiated by users, detailing what content was downloaded, when, and the size of the files.

DownloadID: A unique identifier for each download event.
UserID: The ID of the user who initiated the download.
MovieID/SeriesID: The ID of the movie or series that was downloaded.
DownloadDate: The date and time the download was initiated.
ContentType: The type of content downloaded, either a movie or series.
Status: The status of the download (e.g., in progress, completed).
FileSize: The size of the downloaded file in bytes.
tblSeries
This table contains information about TV series available on the platform.

SeriesID: A unique identifier for each series.
GenreID: The genre the series belongs to.
Title: The title of the series.
Season: The season number of the series.
EpisodeCount: The number of episodes in the series.
StartYear/EndYear: The year the series started and ended (if it has concluded).
Country: The country of origin of the series.
tblGenres
This table defines the different genres that can be associated with movies and series.

GenreID: A unique identifier for each genre.
Name: The name of the genre (e.g., action, drama, comedy).
Description: A more detailed description of what the genre entails.
tblMovies
This table stores details about the individual movies available for streaming and downloading.

MovieID: A unique identifier for each movie.
GenreID: The genre the movie belongs to.
Title: The title of the movie.
Description: A brief synopsis of the movie.
Director: The director of the movie.
ReleaseDate: The release date of the movie.
Duration: The runtime of the movie, typically in minutes.
This overview should provide a clear understanding of the purpose of each table and how they relate to one another within the ShowStream platform. If further details or features need to be explained, such as specific administrative functionalities or user actions, those can be added to the descriptions accordingly.
