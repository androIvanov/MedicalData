using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalData.Migrations
{
    public partial class relationsDone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BillingProviderProviderId",
                table: "Subscribers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EDI837MessageMessageId",
                table: "Subscribers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EDI835MessageMessageId",
                table: "ClaimPayments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subscribers_BillingProviderProviderId",
                table: "Subscribers",
                column: "BillingProviderProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscribers_EDI837MessageMessageId",
                table: "Subscribers",
                column: "EDI837MessageMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicePayments_ClaimPaymentId",
                table: "ServicePayments",
                column: "ClaimPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceLines_ClaimId",
                table: "ServiceLines",
                column: "ClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_Providers_ClaimId",
                table: "Providers",
                column: "ClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_SubscriberId",
                table: "Patients",
                column: "SubscriberId");

            migrationBuilder.CreateIndex(
                name: "IX_LineNumbers_TransactionId",
                table: "LineNumbers",
                column: "TransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_Claims_SubscriberId",
                table: "Claims",
                column: "SubscriberId");

            migrationBuilder.CreateIndex(
                name: "IX_ClaimPayments_EDI835MessageMessageId",
                table: "ClaimPayments",
                column: "EDI835MessageMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_ClaimPayments_TransactionId",
                table: "ClaimPayments",
                column: "TransactionId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClaimPayments_EDI835Messages_EDI835MessageMessageId",
                table: "ClaimPayments",
                column: "EDI835MessageMessageId",
                principalTable: "EDI835Messages",
                principalColumn: "MessageId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClaimPayments_Transactions_TransactionId",
                table: "ClaimPayments",
                column: "TransactionId",
                principalTable: "Transactions",
                principalColumn: "TransactionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Claims_Subscribers_SubscriberId",
                table: "Claims",
                column: "SubscriberId",
                principalTable: "Subscribers",
                principalColumn: "SubscriberId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LineNumbers_Transactions_TransactionId",
                table: "LineNumbers",
                column: "TransactionId",
                principalTable: "Transactions",
                principalColumn: "TransactionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Subscribers_SubscriberId",
                table: "Patients",
                column: "SubscriberId",
                principalTable: "Subscribers",
                principalColumn: "SubscriberId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Providers_Claims_ClaimId",
                table: "Providers",
                column: "ClaimId",
                principalTable: "Claims",
                principalColumn: "ClaimId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceLines_Claims_ClaimId",
                table: "ServiceLines",
                column: "ClaimId",
                principalTable: "Claims",
                principalColumn: "ClaimId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServicePayments_ClaimPayments_ClaimPaymentId",
                table: "ServicePayments",
                column: "ClaimPaymentId",
                principalTable: "ClaimPayments",
                principalColumn: "ClaimPaymentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscribers_BillingProviders_BillingProviderProviderId",
                table: "Subscribers",
                column: "BillingProviderProviderId",
                principalTable: "BillingProviders",
                principalColumn: "ProviderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscribers_EDI837Message_EDI837MessageMessageId",
                table: "Subscribers",
                column: "EDI837MessageMessageId",
                principalTable: "EDI837Message",
                principalColumn: "MessageId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClaimPayments_EDI835Messages_EDI835MessageMessageId",
                table: "ClaimPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_ClaimPayments_Transactions_TransactionId",
                table: "ClaimPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_Claims_Subscribers_SubscriberId",
                table: "Claims");

            migrationBuilder.DropForeignKey(
                name: "FK_LineNumbers_Transactions_TransactionId",
                table: "LineNumbers");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Subscribers_SubscriberId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Providers_Claims_ClaimId",
                table: "Providers");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceLines_Claims_ClaimId",
                table: "ServiceLines");

            migrationBuilder.DropForeignKey(
                name: "FK_ServicePayments_ClaimPayments_ClaimPaymentId",
                table: "ServicePayments");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscribers_BillingProviders_BillingProviderProviderId",
                table: "Subscribers");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscribers_EDI837Message_EDI837MessageMessageId",
                table: "Subscribers");

            migrationBuilder.DropIndex(
                name: "IX_Subscribers_BillingProviderProviderId",
                table: "Subscribers");

            migrationBuilder.DropIndex(
                name: "IX_Subscribers_EDI837MessageMessageId",
                table: "Subscribers");

            migrationBuilder.DropIndex(
                name: "IX_ServicePayments_ClaimPaymentId",
                table: "ServicePayments");

            migrationBuilder.DropIndex(
                name: "IX_ServiceLines_ClaimId",
                table: "ServiceLines");

            migrationBuilder.DropIndex(
                name: "IX_Providers_ClaimId",
                table: "Providers");

            migrationBuilder.DropIndex(
                name: "IX_Patients_SubscriberId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_LineNumbers_TransactionId",
                table: "LineNumbers");

            migrationBuilder.DropIndex(
                name: "IX_Claims_SubscriberId",
                table: "Claims");

            migrationBuilder.DropIndex(
                name: "IX_ClaimPayments_EDI835MessageMessageId",
                table: "ClaimPayments");

            migrationBuilder.DropIndex(
                name: "IX_ClaimPayments_TransactionId",
                table: "ClaimPayments");

            migrationBuilder.DropColumn(
                name: "BillingProviderProviderId",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "EDI837MessageMessageId",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "EDI835MessageMessageId",
                table: "ClaimPayments");
        }
    }
}
