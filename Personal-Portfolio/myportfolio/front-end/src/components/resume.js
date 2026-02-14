import cv from './SG-Abdallah Alhajahmed.pdf';

function Resume() {
    return (
      <section  id="resume">
        <h4 className="heading mb-2 mt-4 text-center" style={{fontSize: "20px",}}>Sparta Global Profile</h4>
        <div className="p-3">
          <div className="container single-col-max-width text-center">
                <a 
                class="btn btn-secondary btn-lg" 
                rel="noreferrer" 
                href={cv} 
                download="Abdallah Alhajahmed.pdf"
                >
                  Download my Profile <i className="fa fa-download"></i></a>
          </div>
       </div>
      </section>
    );
}
export default Resume;