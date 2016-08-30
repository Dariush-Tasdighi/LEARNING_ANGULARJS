declare module server {
	interface Person extends BaseEntity {
		/** ********** */
		age: number;
		/** ******************** */
		isActive: boolean;
		/** ******************** */
		lastName: string;
		/** ******************** */
		firstName: string;
	}
	interface BaseEntity {
		id: any;
	}
}
