using Progressed;

IProgressable file = new CustomFile();
file.Length = 1000;
file.Sent = 1;

Progress progress = new Progress(new Music() { Length = 2000, Sent = 330});
progress.currentProgress();