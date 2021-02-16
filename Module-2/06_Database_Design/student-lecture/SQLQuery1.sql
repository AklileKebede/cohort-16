Select artist.ArtistID, ArtistName, Title, TransactionDate, TransPrice
From ArtTransaction atr
	Join Painting on Painting.PaintingID=atr.PaintingID
	Join Artist on Painting.ArtistID=Artist.ArtistID