
import { HttpClient } from '@angular/common/http';

export class VotingComponent {
  selectedCandidate!: number;
  selectedVoter!: number;

  constructor(private http: HttpClient) {}

  vote() {
    this.http.post('/api/votes', {
      candidateId: this.selectedCandidate,
      voterId: this.selectedVoter
    }).subscribe();
  }
}
