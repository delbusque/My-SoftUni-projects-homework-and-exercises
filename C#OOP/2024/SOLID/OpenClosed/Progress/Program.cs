using Progressed;

IProgressable file = new CustomFile();
file.Length = 1000;
file.Sent = 1;

IProgressable song = new Music();
song.Length = 4300;
song.Sent = 12;

Progress progress = new Progress(song);
progress.currentProgress();